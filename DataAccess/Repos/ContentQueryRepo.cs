using BusinessCls = FileworxNews.Business.Models;
using FileworxNews.Business.Queries;
using FileworxNews.Business.Repos;
using FileworxNews.DataAccess.Context;
using FileworxNews.DataAccess.Entities;
using FileworxNews.DataAccess.Mapping;

namespace FileworxNews.DataAccess.Repos
{
    public class ContentQueryRepo :FileworxEntityQRepo , IContentQueryRepo
    {
        private readonly FileworxDbContext _context;

        private ContentQuery _queryObj;

        public ContentQueryRepo(FileworxDbContext context)
        : base(context)
        {

            _context = context;
        }

        protected IQueryable<Content> QueryBuilder(IQueryable<Content> query , ContentQuery queryObj)
        {
            query = base.QueryBuilder(query , _queryObj).OfType<Content>();

            if (_queryObj.QBody.FilterType.HasValue)
            {
                StringFilterHandling(ref query, _queryObj.QBody);
            }

            if (_queryObj.QDescription.FilterType.HasValue)
            {
                StringFilterHandling(ref query, _queryObj.QDescription);
            }

            return query;

        }

        protected void StringFilterHandling(ref IQueryable<Content> query, StringFilter TargetProperty)
        {

            if (TargetProperty == _queryObj.QBody)
            {
                string targetString = _queryObj.QBody.Value.Trim();

                switch (_queryObj.QBody.FilterType)
                {

                    case StringFilterType.Exact:
                        query = query.Where(x => x.Body == targetString);
                        break;
                    case StringFilterType.Contains:
                        query = query.Where(x => x.Body.Contains(targetString));
                        break;
                    case StringFilterType.StartsWith:
                        query = query.Where(x => x.Body.StartsWith(targetString));
                        break;
                    case StringFilterType.EndsWith:
                        query = query.Where(x => x.Body.EndsWith(targetString));
                        break;
                }
            }
            else if (TargetProperty == _queryObj.QDescription)
            {
                string targetString = _queryObj.QDescription.Value.Trim();
                switch (_queryObj.QDescription.FilterType)
                {

                    case StringFilterType.Exact:
                        query = query.Where(x => x.Description == targetString);
                        break;
                    case StringFilterType.Contains:
                        query = query.Where(x => x.Description.Contains(targetString));
                        break;
                    case StringFilterType.StartsWith:
                        query = query.Where(x => x.Description.StartsWith(targetString));
                        break;
                    case StringFilterType.EndsWith:
                        query = query.Where(x => x.Description.EndsWith(targetString));
                        break;
                }

            }

        }

        public List<BusinessCls.Content> Run(ContentQuery queryObject)
        {
            _queryObj = queryObject;
            var query = _context.Content;
            var result = QueryBuilder(query, _queryObj).ToList();
            return ContentMapper.ToBusinessList(result);
        }
    }
}

