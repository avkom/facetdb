using System;
using System.Collections.Generic;

namespace FacetDb
{
    public class FacetDatabase
    {
	    private readonly Dictionary<string, Column> _columns;

	    public FacetDatabase()
	    {
		    _columns = new Dictionary<string, Column>();
	    }

		public void AddColumn(string name, Type type)
	    {
		    Column column = new Column(type);
			_columns.Add(name, column);
	    }

	    public void AddRow(params object[] values)
	    {

	    }

	    public QueryResult QueryRows(Query query)
	    {
		    throw new NotImplementedException();
	    }
    }
}
