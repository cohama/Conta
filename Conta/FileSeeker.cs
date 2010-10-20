using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Conta
{
	public class FileSeeker
	{
		int fileindex;
		string[] files;

		public string CurrentFile
		{
			get
			{
				if( this.files == null )
				{
					throw new InvalidOperationException( "現在のファイルが有効ではありません" );
				}
				return this.files[this.fileindex];
			}
		}
		public string CurrentDirectory { get; private set; }

		public FileSeeker()
		{

		}

		public FileSeeker( string file )
		{
			this.SetBaseFile( file );
		}

		public void SetBaseFile( string file )
		{
			this.CurrentDirectory = Path.GetDirectoryName( file );
			this.Reload();
			this.fileindex = Array.FindIndex( this.files, str => str == file );
		}

		public void Reload()
		{
			this.files = Directory.GetFiles( this.CurrentDirectory, "*.txt", SearchOption.TopDirectoryOnly );
			this.fileindex = Array.FindIndex( this.files, filename => this.CurrentFile == filename );
		}

		public string NextFile()
		{
			if( this.files == null )
			{
				throw new InvalidOperationException( "現在のファイルが有効ではありません" );
			}
			if( this.fileindex == this.files.Length-1 )
			{
				this.Reload();
				if( this.fileindex == this.files.Length-1 )
				{
					this.fileindex = 0;
				}
				else
				{
					this.fileindex++;
				}

			}
			else
			{
				this.fileindex++;
			}
			return this.CurrentFile;
		}

		public string PreviousFile()
		{
			if( this.files == null )
			{
				throw new InvalidOperationException( "現在のファイルが有効ではありません" );
			}
			if( this.fileindex == 0 )
			{
				this.Reload();
				if( this.fileindex == 0 )
				{
					this.fileindex = this.files.Length-1;
				}
				else
				{
					this.fileindex--;
				}
			}
			else
			{
				this.fileindex--;
			}
			return this.CurrentFile;
		}
	}
}
