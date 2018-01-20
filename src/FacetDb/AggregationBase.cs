using System.Collections.Generic;

namespace FacetDb
{
    public abstract class AggregationBase
    {
		public string ColumnName { get; set; }

	    public abstract void Visit(List<object> columns, int index);
    }
}
