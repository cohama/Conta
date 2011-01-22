using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Visualization
{
	abstract class Field
	{
		public abstract void DrawTo( Canvas canvas, IDataSheet data );
	}
}
