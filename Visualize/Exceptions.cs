using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visualization
{
	class VectorDataNotFoundException : ApplicationException
	{
		public VectorDataNotFoundException( string message )
			: base( message )
		{ }
		public VectorDataNotFoundException( string message, Exception innerException )
			: base( message, innerException )
		{ }
	}

	class DataFormatException : ApplicationException
	{
		public string FileName { get; private set; }

		public DataFormatException( string filename, string message, Exception innerException )
			: base( message, innerException )
		{
			this.FileName = filename;
		}
	}
}
