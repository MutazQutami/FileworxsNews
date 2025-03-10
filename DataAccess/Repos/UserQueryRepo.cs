using BusinessCls = FileworxNews.Business.Models;
using FileworxNews.Business.Queries;
using FileworxNews.Business.Repos;
using FileworxNews.DataAccess.Context;
using FileworxNews.DataAccess.Entities;
using FileworxNews.DataAccess.Mapping;

namespace FileworxNews.DataAccess.Repos
{
    public class UserQueryRepo : FileworxEntityQRepo, IUserQueryRepo
    {
        private readonly FileworxDbContext _context;

        private UserQuery _queryObj;

        public UserQueryRepo(FileworxDbContext context)
            :base(context)
        {
            _context = context;
        }

        protected IQueryable<User> QueryBuilder(IQueryable<User> query)
        {
            query = base.QueryBuilder(query , _queryObj).OfType<User>();

            if (_queryObj.QLogInName.FilterType.HasValue)
            {
                StringFilterHandling(ref query, _queryObj.QLogInName);
            }

            if (_queryObj.QPassword.FilterType.HasValue)
            {
                StringFilterHandling(ref query, _queryObj.QPassword);
            }
            if (_queryObj.QIsAdmin.HasValue)
            {
                query = query.Where(X => X.IsAdmin == _queryObj.QIsAdmin);
            }
            return query;

        }

        protected void StringFilterHandling(ref IQueryable<User> query, StringFilter TargetProperty)
        {
            if (TargetProperty == _queryObj.QLogInName)
            {
                string targetString = _queryObj.QLogInName.Value;

                switch (_queryObj.QLogInName.FilterType)
                {

                    case StringFilterType.Exact:
                        query = query.Where(x => x.LogInName == targetString);
                        break;
                    case StringFilterType.Contains:
                        query = query.Where(x => x.LogInName.Contains(targetString));
                        break;
                    case StringFilterType.StartsWith:
                        query = query.Where(x => x.LogInName.StartsWith(targetString));
                        break;
                    case StringFilterType.EndsWith:
                        query = query.Where(x => x.LogInName.EndsWith(targetString));
                        break;
                }
            }
            else if (TargetProperty == _queryObj.QPassword)
            {
                string targetString = _queryObj.QPassword.Value;
                switch (_queryObj.QPassword.FilterType)
                {

                    case StringFilterType.Exact:
                        query = query.Where(x => x.Password == targetString);
                        break;
                    case StringFilterType.Contains:
                        query = query.Where(x => x.Password.Contains(targetString));
                        break;
                    case StringFilterType.StartsWith:
                        query = query.Where(x => x.Password.StartsWith(targetString));
                        break;
                    case StringFilterType.EndsWith:
                        query = query.Where(x => x.Password.EndsWith(targetString));
                        break;
                }

            }
        }

        public List<BusinessCls.User> Run(UserQuery queryObject)
        {
            _queryObj = queryObject;
            var query = _context.User;
            var result = QueryBuilder(query).ToList();
            return UserMapper.ToBusinessList(result);
        }
    }
}
