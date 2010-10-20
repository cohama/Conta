using System;
namespace Visualization
{
	interface IDataSheet
	{
		double AspectRatio { get; }
		int Columns { get; }
		double GetScalar( int i, int j );
		double GetU( int i, int j );
		double GetV( int i, int j );
		bool HasVectorData { get; set; }
		double MaxValue { get; }
		double MinValue { get; }
		int Rows { get; }
	}
}
