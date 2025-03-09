using FileworxNews.Business.Queries;
using FileworxNews.Business.Models;
using FileworxNews.Business.Repos;
using FileworxNews.DataAccess.Context;



namespace FileworxNews.DataAccess.Repos
{
    public class FileworxEntityQReop : IfileworxEntityQueryRepo
    {
        private readonly FileworxDbContext _context;

        private FileworxEntityQuery _queryObj;

        public FileworxEntityQReop(FileworxDbContext context)
        {
            _context = context;
        }

        protected virtual void DateFilterHandling(ref IQueryable<FileWorxEntity> query, DateFilter TargetProperty)
        {
            if (TargetProperty == _queryObj.QCreationDate)
            {
                switch (_queryObj.QCreationDate.FilterType)
                {
                    case DateFilterType.Exact:
                        query = query.Where(x => x.CreationDate.Date == _queryObj.QCreationDate.Value.Date);
                        break;
                    case DateFilterType.Before:
                        query = query.Where(x => x.CreationDate.Date < _queryObj.QCreationDate.Value.Date);
                        break;
                    case DateFilterType.After:
                        query = query.Where(x => x.CreationDate.Date > _queryObj.QCreationDate.Value.Date);
                        break;
                    case DateFilterType.Range:
                        if (!_queryObj.QCreationDate.Value.Equals(null) && !_queryObj.QCreationDate.EndDate.Equals(null))
                        {

                            query = query.Where(x => x.CreationDate.Date >= _queryObj.QCreationDate.Value.Date && x.CreationDate.Date <= _queryObj.QCreationDate.EndDate.Date);
                        }
                        break;
                    case DateFilterType.Today:
                        var today = DateTime.Today.Date;
                        query = query.Where(x => x.CreationDate.Date == today);
                        break;
                }

            }
            else if (TargetProperty == _queryObj.QLastModificationDate)
            {
                switch (_queryObj.QLastModificationDate.FilterType)
                {
                    case DateFilterType.Exact:
                        if (!_queryObj.QLastModificationDate.Value.Equals(null))
                            query = query.Where(x => x.LastModificationDate.Date == _queryObj.QLastModificationDate.Value.Date);
                        break;

                    case DateFilterType.Before:
                        if (!_queryObj.QLastModificationDate.Value.Equals(null))
                            query = query.Where(x => x.LastModificationDate.Date < _queryObj.QLastModificationDate.EndDate.Date);
                        break;

                    case DateFilterType.After:
                        if (!_queryObj.QLastModificationDate.Value.Equals(null))
                            query = query.Where(x => x.LastModificationDate.Date > _queryObj.QLastModificationDate.EndDate.Date);
                        break;

                    case DateFilterType.Range:
                        if (!_queryObj.QLastModificationDate.Value.Equals(null) && !_queryObj.QLastModificationDate.EndDate.Equals(null))
                            query = query.Where(x => x.LastModificationDate.Date >= _queryObj.QLastModificationDate.Value.Date
                            && x.LastModificationDate.Date <= _queryObj.QLastModificationDate.EndDate.Date);
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
            string targetString = _queryObj.QName.Value.Trim();
            switch (_queryObj.QName.FilterType)
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

        protected virtual IQueryable<FileWorxEntity> QueryBuilder(IQueryable<FileWorxEntity> query)
        {
            if (_queryObj.QCreationDate.FilterType.HasValue)
            {
                DateFilterHandling(ref query, _queryObj.QCreationDate);
            }

            if (_queryObj.QLastModificationDate.FilterType.HasValue)
            {
                DateFilterHandling(ref query, _queryObj.QLastModificationDate);
            }

            if (_queryObj.QName.FilterType.HasValue)
            {
                StringFilterHandling(ref query);
            }

            if (_queryObj.QLastModifierId.HasValue)
            {
                query = query.Where(x => x.LastModifierId == _queryObj.QLastModifierId.Value);
            }

            if (_queryObj.QCreatorId.HasValue)
            {
                query = query.Where(x => x.CreatorId == _queryObj.QCreatorId.Value);
            }
            if (_queryObj.QId.HasValue)
            {
                query = query.Where(x => x.Id == _queryObj.QId.Value);
            }

            return query;

        }

        public List<FileWorxEntity> Run(FileworxEntityQuery queryObj)
        {
            _queryObj = queryObj;
            var query = _context.Entity;

            return QueryBuilder(query).ToList();
        }
    }
}

//public class test
//{

//    public DateFilter QCreationDate = new DateFilter();

//    public DateFilter QLastModificationDate = new DateFilter();

//    public StringFilter QName = new StringFilter();

//    public Guid? QId { get; set; }

//    public Guid? QLastModifierId { get; set; }

//    public Guid? QCreatorId { get; set; }

//    protected virtual IQueryable<FileWorxEntity> QueryBuilder(Context context)
//    {
//        IQueryable<FileWorxEntity> query = context.Entity;

//        if (QCreationDate.FilterType.HasValue)
//        {
//            DateFilterHandling(ref query, QCreationDate);
//        }

//        if (QLastModificationDate.FilterType.HasValue)
//        {
//            DateFilterHandling(ref query, QLastModificationDate);
//        }

//        if (QName.FilterType.HasValue)
//        {
//            StringFilterHandling(ref query);
//        }

//        if (QLastModifierId.HasValue)
//        {
//            query = query.Where(x => x.LastModifierId == QLastModifierId.Value);
//        }

//        if (QCreatorId.HasValue)
//        {
//            query = query.Where(x => x.CreatorId == QCreatorId.Value);

//        }

//        if (QId.HasValue)
//        {
//            query = query.Where(x => x.Id == QId.Value);
//        }

//        return query;
//    }

//    protected virtual void DateFilterHandling(ref IQueryable<FileWorxEntity> query, DateFilter TargetProperty)
//    {
//        if (TargetProperty == QCreationDate)
//        {
//            switch (QCreationDate.FilterType)
//            {
//                case DateFilterType.Exact:
//                    query = query.Where(x => x.CreationDate.Date == QCreationDate.Value.Date);
//                    break;
//                case DateFilterType.Before:
//                    query = query.Where(x => x.CreationDate.Date < QCreationDate.Value.Date);
//                    break;
//                case DateFilterType.After:
//                    query = query.Where(x => x.CreationDate.Date > QCreationDate.Value.Date);
//                    break;
//                case DateFilterType.Range:
//                    if (!QCreationDate.Value.Equals(null) && !QCreationDate.EndDate.Equals(null))
//                    {

//                        query = query.Where(x => x.CreationDate.Date >= QCreationDate.Value.Date && x.CreationDate.Date <= QCreationDate.EndDate.Date);
//                    }
//                    break;
//                case DateFilterType.Today:
//                    var today = DateTime.Today.Date;
//                    query = query.Where(x => x.CreationDate.Date == today);
//                    break;
//            }

//        }
//        else if (TargetProperty == QLastModificationDate)
//        {
//            switch (QLastModificationDate.FilterType)
//            {
//                case DateFilterType.Exact:
//                    if (!QLastModificationDate.Value.Equals(null))
//                        query = query.Where(x => x.LastModificationDate.Date == QLastModificationDate.Value.Date);
//                    break;

//                case DateFilterType.Before:
//                    if (!QLastModificationDate.Value.Equals(null))
//                        query = query.Where(x => x.LastModificationDate.Date < QLastModificationDate.EndDate.Date);
//                    break;

//                case DateFilterType.After:
//                    if (!QLastModificationDate.Value.Equals(null))
//                        query = query.Where(x => x.LastModificationDate.Date > QLastModificationDate.EndDate.Date);
//                    break;

//                case DateFilterType.Range:
//                    if (!QLastModificationDate.Value.Equals(null) && !QLastModificationDate.EndDate.Equals(null))
//                        query = query.Where(x => x.LastModificationDate.Date >= QLastModificationDate.Value.Date
//                        && x.LastModificationDate.Date <= QLastModificationDate.EndDate.Date);
//                    break;

//                case DateFilterType.Today:
//                    var today = DateTime.Today;
//                    query = query.Where(x => x.LastModificationDate.Date == today);
//                    break;
//            }
//        }
//    }

//    protected virtual void StringFilterHandling(ref IQueryable<FileWorxEntity> query)
//    {
//        string targetString = QName.Value.Trim();
//        switch (QName.FilterType)
//        {
//            case StringFilterType.Exact:
//                query = query.Where(x => x.Name == targetString);
//                break;
//            case StringFilterType.Contains:
//                query = query.Where(x => x.Name.Contains(targetString));
//                break;
//            case StringFilterType.StartsWith:
//                query = query.Where(x => x.Name.StartsWith(targetString));
//                break;
//            case StringFilterType.EndsWith:
//                query = query.Where(x => x.Name.EndsWith(targetString));
//                break;
//        }

//    }

//    public List<FileWorxEntity> Run()
//    {
//        using (var context = new Context())
//        {
//            return QueryBuilder(context).ToList();
//        }
//    }
//}




