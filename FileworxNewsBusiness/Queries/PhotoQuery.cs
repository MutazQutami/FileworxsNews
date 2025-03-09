//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using static FileworxNews.Business.StringFilter;

//namespace FileworxNews.Business
//{
//    public  class PhotoQuery :ContentQuery
//    {
//        public  StringFilter QPhotoPath = new StringFilter();
//        protected IQueryable<Photo> QueryBuilder(Context context)
//        {
//            IQueryable<Photo> query = context.Photo;

//            query = base.QueryBuilder(context).OfType<Photo>();

//            if (QPhotoPath.FilterType.HasValue)
//            {
//                StringFilterHandling(ref query, QPhotoPath);
//            }

//            return query;
//        }

//        protected void StringFilterHandling(ref IQueryable<Photo> query, StringFilter TargetProperty)
//        {

//            if (TargetProperty == QPhotoPath)
//            {
//                string targetString = QPhotoPath.Value;

//                switch (QPhotoPath.FilterType)
//                {

//                    case StringFilterType.Exact:
//                        query = query.Where(x => x.PhotoPath == targetString);
//                        break;
//                    case StringFilterType.Contains:
//                        query = query.Where(x => x.PhotoPath.Contains(targetString));
//                        break;
//                    case StringFilterType.StartsWith:
//                        query = query.Where(x => x.PhotoPath.StartsWith(targetString));
//                        break;
//                    case StringFilterType.EndsWith:
//                        query = query.Where(x => x.PhotoPath.EndsWith(targetString));
//                        break;
//                }
//            }
            
//        }

//        public List<Photo> Run()
//        {
//            using (var context = new Context())
//            {
//                return QueryBuilder(context).ToList();
//            }
//        }
//    }
//}
