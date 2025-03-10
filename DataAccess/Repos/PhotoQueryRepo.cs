using BusinessCls = FileworxNews.Business.Models;
using FileworxNews.Business.Queries;
using FileworxNews.Business.Repos;
using FileworxNews.DataAccess.Context;
using FileworxNews.DataAccess.Mapping;
using FileworxNews.DataAccess.Entities;


namespace FileworxNews.DataAccess.Repos
{
    public class PhotoQueryRepo :ContentQueryRepo , IPhotoQueryRepo
    {
        private readonly FileworxDbContext _context;

        private  PhotoQuery _queryObj;

        public PhotoQueryRepo(FileworxDbContext context)
            : base(context)
        {
            _context=context;
        }

        protected IQueryable<Photo> QueryBuilder(IQueryable<Photo> query )
        {
            query = base.QueryBuilder(query, _queryObj).OfType<Photo>();

            if (_queryObj.QPhotoPath.FilterType.HasValue)
            {
                StringFilterHandling(ref query, _queryObj.QPhotoPath);
            }

            return query;
        }

        protected void StringFilterHandling(ref IQueryable<Photo> query, StringFilter TargetProperty)
        {
            if (TargetProperty == _queryObj.QPhotoPath)
            {
                string targetString = _queryObj.QPhotoPath.Value;

                switch (_queryObj.QPhotoPath.FilterType)
                {

                    case StringFilterType.Exact:
                        query = query.Where(x => x.PhotoPath == targetString);
                        break;
                    case StringFilterType.Contains:
                        query = query.Where(x => x.PhotoPath.Contains(targetString));
                        break;
                    case StringFilterType.StartsWith:
                        query = query.Where(x => x.PhotoPath.StartsWith(targetString));
                        break;
                    case StringFilterType.EndsWith:
                        query = query.Where(x => x.PhotoPath.EndsWith(targetString));
                        break;
                }
            }

        }

        public List<BusinessCls.Photo> Run(PhotoQuery queryObject)
        {
            _queryObj = queryObject;
            var query = _context.Photo;
            var result = QueryBuilder(query).ToList();
            return  PhotoMapper.ToBusinessList(result);
        }
    }
}
