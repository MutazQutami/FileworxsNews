using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileworxNewsBusiness
{
    public class DateFilter
    {
        public enum DateFilterType
        {
            Exact,
            Before,
            After,
            Range,
            Today
        }

        public DateFilterType? FilterType { get; set; }

        public DateTime Value { get; set; }

        public DateTime EndDate { get; set; }

    }
}
