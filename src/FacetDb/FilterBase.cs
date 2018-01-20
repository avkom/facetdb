using System.Collections.Generic;

namespace FacetDb
{
	public abstract class FilterBase
    {
		public string ColumnName { get; set; }

	    public abstract bool Match(List<object> columns, int index);
    }
}
