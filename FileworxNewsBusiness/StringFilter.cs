namespace FileworxNewsBusiness
{
    public class StringFilter
    {
        public enum StringFilterType
        {
            Exact,
            Contains,
            StartsWith,
            EndsWith
        }

        public string Value { get; set; }
        public StringFilterType? FilterType { get; set; }
    }

}
