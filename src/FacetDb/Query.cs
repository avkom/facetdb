using System.Collections.Generic;

namespace FacetDb
{
    public class Query
    {
		public List<FilterBase> Filters { get; private set; }

		public List<AggregationBase> Aggregations { get; private set; }

		public int Skip { get; set; }

		public int Take { get; set; }

		public string OrderBy { get; set; }

		public bool Descending { get; set; }

		public bool IncludeTotalCount { get; set; }

		public Query()
	    {
		    Filters = new List<FilterBase>();
			Aggregations = new List<AggregationBase>();
		}
    }
}
