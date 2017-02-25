using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Albert.Flex;
namespace aPowerBox
{
	public class WebFile: Notify
	{
		string filename;


		public string FileName
		{
			get { return filename; }
			set { filename = value; OnPropertyChanged("FIleName"); }
		}

	}
}
