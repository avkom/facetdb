using System;
using System.Collections.Generic;

namespace FacetDb
{
	public class Filter<TColumn> : FilterBase
	{
		public Predicate<TColumn> Predicate { get; set; }

		public override bool Match(List<object> columns, int index)
		{
			throw new NotImplementedException();
		}
	}
}