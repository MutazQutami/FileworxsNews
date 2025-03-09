//using FileworxNews.Business.Models;
//using FileworxNews.Queries;


//namespace FileworxNews.Business.Queries
//{
//    public class ContentQuery : FileworxEntityQuery
//    {
//        public StringFilter QDescription = new StringFilter();

//        public StringFilter QBody = new StringFilter();

//        protected IQueryable<Content> QueryBuilder(Context context)
//        {
//            IQueryable<Content> query = context.Content;

//            query = base.QueryBuilder(context).OfType<Content>();

//            if (QBody.FilterType.HasValue)
//            {
//                StringFilterHandling(ref query, QBody);
//            }

//            if (QDescription.FilterType.HasValue)
//            {
//                StringFilterHandling(ref query, QDescription);
//            }

//            return query;

//        }

//        protected void StringFilterHandling(ref IQueryable<Content> query, StringFilter TargetProperty)
//        {

//            if (TargetProperty == QBody)
//            {
//                string targetString = QBody.Value.Trim();

//                switch (QBody.FilterType)
//                {

//                    case StringFilterType.Exact:
//                        query = query.Where(x => x.Body == targetString);
//                        break;
//                    case StringFilterType.Contains:
//                        query = query.Where(x => x.Body.Contains(targetString));
//                        break;
//                    case StringFilterType.StartsWith:
//                        query = query.Where(x => x.Body.StartsWith(targetString));
//                        break;
//                    case StringFilterType.EndsWith:
//                        query = query.Where(x => x.Body.EndsWith(targetString));
//                        break;
//                }
//            }
//            else if (TargetProperty == QDescription)
//            {
//                string targetString = QDescription.Value.Trim();
//                switch (QDescription.FilterType)
//                {

//                    case StringFilterType.Exact:
//                        query = query.Where(x => x.Description == targetString);
//                        break;
//                    case StringFilterType.Contains:
//                        query = query.Where(x => x.Description.Contains(targetString));
//                        break;
//                    case StringFilterType.StartsWith:
//                        query = query.Where(x => x.Description.StartsWith(targetString));
//                        break;
//                    case StringFilterType.EndsWith:
//                        query = query.Where(x => x.Description.EndsWith(targetString));
//                        break;
//                }

//            }

//        }

//        public List<Content> Run()
//        {
//            using (var context = new Context())
//            {
//                return QueryBuilder(context).ToList();
//            }
//        }
//    }
//}
