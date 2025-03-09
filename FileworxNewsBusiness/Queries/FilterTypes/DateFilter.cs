namespace FileworxNews.Business.Queries;

public enum DateFilterType
{
    Exact,
    Before,
    After,
    Range,
    Today
}

public class DateFilter
{
  
    public DateFilterType? FilterType { get; set; }

    public DateTime Value { get; set; }

    public DateTime EndDate { get; set; }
}
