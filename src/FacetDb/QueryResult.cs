using System.Collections.Generic;

namespace FacetDb
{
    public class QueryResult
    {
		public List<List<object>> Rows { get; set; }

		public List<AggregationResultBase> Aggregations { get; set; }

		public int TotalCount { get; set; }
	}
}
