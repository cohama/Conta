using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visualization
{
	public abstract class FieldSetting
	{
		/// <summary>
		/// フィールドを描画するかどうかを取得、設定します。
		/// </summary>
		public bool Show { get; set; }
	}
}
