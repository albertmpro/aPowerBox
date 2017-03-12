using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Albert.Flex.Runtime;
using System.IO;
using Windows.Data.Pdf;
using static Albert.Flex.Runtime.AsyncIO;
using static Albert.Flex.Runtime.Device10x;
using Windows.UI.Xaml.Controls;

namespace aPowerIdea
{
	public class IdeaViewModel: ViewModel
	{

		#region Event  and Method's 
		/// <summary>
		/// Navigation for the ViewModel 
		/// </summary>
		/// <param name="_page"></param>
		public static void VMNavigate(Type _page)
		{
			//Navigate to the Frame 
			VMFrame?.Navigate(_page);

			//Close the Pane View of the Application 
			if (VMSplitView != null)
				VMSplitView.IsPaneOpen = false;
		}


		/// <summary>
		/// A static  Action Event that can be used to notify the Application 
		/// </summary>
		public static Action<string> VMNotify;
		#endregion


		#region Poperties 

		/// <summary>
		/// Gets or set the Default Frame that you may want to use 
		/// </summary>
		public static Frame VMFrame { get; set; }
		/// <summary>
		/// Gets or sets the Default SplitView You might want to use 
		/// </summary>
		public static SplitView VMSplitView { get; set; }

	
	




		#endregion
	}
}
