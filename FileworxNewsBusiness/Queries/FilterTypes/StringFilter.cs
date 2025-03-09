namespace  FileworxNews.Business.Queries;

public enum StringFilterType
{
    Exact,
    Contains,
    StartsWith,
    EndsWith
}
public class StringFilter
    {
       
        public string Value { get; set; }
        public StringFilterType? FilterType { get; set; }
    }


