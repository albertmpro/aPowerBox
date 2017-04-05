using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Xceed.Wpf.Toolkit;
using static aPowerDesk.DeskViewModel;
namespace aPowerDesk.View
{
	/// <summary>
	/// Interaction logic for NewWindow.xaml
	/// </summary>
	public partial class NewWindow : ChildWindow
	{
		public NewWindow()
		{
			InitializeComponent();
		}

		void link_Click(object sender, RoutedEventArgs e)
		{
			var hype = sender as Hyperlink;

			switch(hype.Tag)
			{
				case "txt":
					var txt = new TextEditor(VMTab);
					// Close the Window 
					Close();
					break;
			}
		}




	}
}
