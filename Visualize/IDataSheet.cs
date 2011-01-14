using System;
namespace Visualization
{
	interface IDataSheet
	{
		double AspectRatio { get; }
		int Columns { get; }
		double GetX( int i );
		double GetY( int j );
		double GetZ( int i, int j );
		double GetU( int i, int j );
		double GetV( int i, int j );
		bool HasVectorData { get; }
		double MaxZ { get; }
		double MinZ { get; }
		int Rows { get; }
	}
}
