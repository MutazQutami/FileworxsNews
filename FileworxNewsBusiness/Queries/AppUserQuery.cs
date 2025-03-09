//using FileworxNews.Business.Repos;

//namespace FileworxNews.Business.Queries
//{
//    public class AppUserQuery : FileworxEntityQuery
//    {
//        private IUserQueryRepo _repo;

//        public StringFilter QLogInName = new StringFilter();

//        public StringFilter QPassword = new StringFilter();

//        public bool? QIsAdmin;
        
//        public AppUserQuery(IUserQueryRepo repo)
//        {
//            _repo = repo;  
//        }
//        protected IQueryable<AppUser> QueryBuilder(Context context)
//        {
//            IQueryable<AppUser> query = context.User;

//            query = base.QueryBuilder(context).OfType<AppUser>();

//            if (QLogInName.FilterType.HasValue)
//            {
//                StringFilterHandling(ref query, QLogInName);
//            }

//            if (QPassword.FilterType.HasValue)
//            {
//                StringFilterHandling(ref query, QPassword);
//            }
//            if (QIsAdmin.HasValue)
//            {
//                query = query.Where(X => X.IsAdmin == QIsAdmin);
//            }
//            return query;

//        }

//        protected void StringFilterHandling(ref IQueryable<AppUser> query, StringFilter TargetProperty)
//        {
//            if (TargetProperty == QLogInName)
//            {
//                string targetString = QLogInName.Value;

//                switch (QLogInName.FilterType)
//                {

//                    case StringFilterType.Exact:
//                        query = query.Where(x => x.LogInName == targetString);
//                        break;
//                    case StringFilterType.Contains:
//                        query = query.Where(x => x.LogInName.Contains(targetString));
//                        break;
//                    case StringFilterType.StartsWith:
//                        query = query.Where(x => x.LogInName.StartsWith(targetString));
//                        break;
//                    case StringFilterType.EndsWith:
//                        query = query.Where(x => x.LogInName.EndsWith(targetString));
//                        break;
//                }
//            }
//            else if (TargetProperty == QPassword)
//            {
//                string targetString = QPassword.Value;
//                switch (QPassword.FilterType)
//                {

//                    case StringFilterType.Exact:
//                        query = query.Where(x => x.Password == targetString);
//                        break;
//                    case StringFilterType.Contains:
//                        query = query.Where(x => x.Password.Contains(targetString));
//                        break;
//                    case StringFilterType.StartsWith:
//                        query = query.Where(x => x.Password.StartsWith(targetString));
//                        break;
//                    case StringFilterType.EndsWith:
//                        query = query.Where(x => x.Password.EndsWith(targetString));
//                        break;
//                }

//            }
//        }

//        public List<AppUser> Run()
//        {
//            using (var context = new Context())
//            {
//                return QueryBuilder(context).ToList();
//            }
//        }
//    }
//}