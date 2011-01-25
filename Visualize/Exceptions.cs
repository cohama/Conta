using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visualization
{
	public class VectorDataNotFoundException : ApplicationException
	{
		public VectorDataNotFoundException( string message )
			: base( message )
		{ }
		public VectorDataNotFoundException( string message, Exception innerException )
			: base( message, innerException )
		{ }
	}

	/// <summary>
	/// 読み込んだファイルからデータを読み出せない場合にスローされる例外。
	/// </summary>
	public class FileCouldNotReadException : ApplicationException
	{
		public FileCouldNotReadException( string message )
			: base( message )
		{ }

		public FileCouldNotReadException( string message, Exception innerException )
			: base( message, innerException )
		{ }
	}

	/// <summary>
	/// 指定した列にデータが存在しなかったときにスローされる例外。
	/// </summary>
	public class DataColumnNotFoundException : ApplicationException
	{
		public string FileName { get; private set; }

		public DataColumnNotFoundException( string filename, string message, Exception innerException )
			: base( message, innerException )
		{
			this.FileName = filename;
		}
	}
}
