using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Albert.Flex;
namespace aPowerBox
{
	public class HtmlPage : Notify
	{
		string filename, content;

		public string FileName
		{
			get { return filename; }
			set { filename = value; OnPropertyChanged("FIleName"); }
		}
		public string Content
		{
			get { return content; }
			set { content = value; OnPropertyChanged("Content"); }
		}



	}
}
