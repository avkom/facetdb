using System.Collections.Generic;

namespace FacetDb
{
    public class AggregationResult<TBucket, TAccumulate> : AggregationResultBase
    {
		public Dictionary<TBucket, TAccumulate> Buckets { get; set; }
	}
}
