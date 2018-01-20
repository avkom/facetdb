using System;
using System.Collections;
using System.Collections.Generic;

namespace FacetDb
{
    public class Column
    {
		public Type Type { get; private set; }

		public IList List { get; private set; }

		public Column(Type type)
		{
			Type = type;

			Type genericListType = typeof(List<>).MakeGenericType(type);
			List = (IList) Activator.CreateInstance(genericListType);
		}
	}
}
