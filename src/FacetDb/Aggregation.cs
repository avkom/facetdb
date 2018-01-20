using System;
using System.Collections.Generic;

namespace FacetDb
{
    public class Aggregation<TColumn, TBucket, TAccumulate> : AggregationBase
    {
		public Func<TBucket, TColumn> BucketProvider { get; set; }

		public Func<TAccumulate, TColumn, TAccumulate> Reducer { get; set; }

		public TAccumulate InitialValue { get; set; }

		public override void Visit(List<object> columns, int index)
	    {
		    throw new NotImplementedException();
	    }
    }
}
