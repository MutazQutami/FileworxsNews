using static FileworxNewsBusiness.DateFilter;
using static FileworxNewsBusiness.StringFilter;

namespace FileworxNewsBusiness;

public class FileworxEntityQuery
{
    public DateFilter QCreationDate = new DateFilter();

    public DateFilter QLastModificationDate = new DateFilter();

    public StringFilter QName = new StringFilter();

    public Guid? QId { get; set; }

    public Guid? QLastModifierId { get; set; }

    public Guid? QCreatorId { get; set; }

    protected virtual void DateFilterHandling(ref IQueryable<FileWorxEntity> query, DateFilter TargetProperty)
    {
        if (TargetProperty == QCreationDate)
        {
            switch (QCreationDate.FilterType)
            {
                case DateFilterType.Exact:
                    query = query.Where(x => x.CreationDate.Date == QCreationDate.Value.Date);
                    break;
                case DateFilterType.Before:
                    query = query.Where(x => x.CreationDate.Date < QCreationDate.Value.Date);
                    break;
                case DateFilterType.After:
                    query = query.Where(x => x.CreationDate.Date > QCreationDate.Value.Date);
                    break;
                case DateFilterType.Range:
                    if (!QCreationDate.Value.Equals(null) && !QCreationDate.EndDate.Equals(null))
                    {

                        query = query.Where(x => x.LastModificationDate.Date >= QLastModificationDate.Value.Date && x.LastModificationDate.Date <= QLastModificationDate.EndDate.Date);
                    }
                    break;
                case DateFilterType.Today:
                    var today = DateTime.Today.Date;
                    query = query.Where(x => x.CreationDate.Date == today);
                    break;
            }

        }
        else if (TargetProperty == QLastModificationDate)
        {
            switch (QLastModificationDate.FilterType)
            {
                case DateFilterType.Exact:
                    if (!QLastModificationDate.Value.Equals(null))
                        query = query.Where(x => x.LastModificationDate == QLastModificationDate.Value);
                    break;

                case DateFilterType.Before:
                    if (!QLastModificationDate.Value.Equals(null))
                        query = query.Where(x => x.LastModificationDate < QLastModificationDate.EndDate);
                    break;

                case DateFilterType.After:
                    if (!QLastModificationDate.Value.Equals(null))
                        query = query.Where(x => x.LastModificationDate > QLastModificationDate.EndDate);
                    break;

                case DateFilterType.Range:
                    if (!QLastModificationDate.Value.Equals(null) && !QLastModificationDate.EndDate.Equals(null))
                        query = query.Where(x => x.LastModificationDate >= QLastModificationDate.Value && x.LastModificationDate <= QLastModificationDate.EndDate);
                    break;

                case DateFilterType.Today:
                    var today = DateTime.Today;
                    query = query.Where(x => x.LastModificationDate.Date == today);
                    break;
            }
        }
    }
   
    protected virtual void StringFilterHandling(ref IQueryable<FileWorxEntity> query)
    {
        string targetString = QName.Value.Trim();
        switch (QName.FilterType)
        {

            case StringFilterType.Exact:
                query = query.Where(x => x.Name == targetString);
                break;
            case StringFilterType.Contains:
                query = query.Where(x => x.Name.Contains(targetString));
                break;
            case StringFilterType.StartsWith:
                query = query.Where(x => x.Name.StartsWith(targetString));
                break;
            case StringFilterType.EndsWith:
                query = query.Where(x => x.Name.EndsWith(targetString));
                break;
        }

    }

    protected virtual IQueryable<FileWorxEntity> QueryBuilder(Context context)
    {
        IQueryable<FileWorxEntity> query = context.Entity;

        if (QCreationDate.FilterType.HasValue)
        {
            DateFilterHandling(ref query, QCreationDate);
        }

        if (QLastModificationDate.FilterType.HasValue)
        {
            DateFilterHandling(ref query, QLastModificationDate);
        }

        if (QName.FilterType.HasValue)
        {
            StringFilterHandling(ref query);
        }

        if (QLastModifierId.HasValue)
        {
            query = query.Where(x => x.LastModifierId == QLastModifierId.Value);
        }

        if (QCreatorId.HasValue)
        {
            query = query.Where(x => x.CreatorId == QCreatorId.Value);

        }

        if (QId.HasValue)
        {
            query = query.Where(x => x.Id == QId.Value);
        }

        return query;
    }
    
    public  List<FileWorxEntity> Run()
    {
        using (var context = new Context())
        {
            return QueryBuilder(context).ToList();
        }
    }

}

