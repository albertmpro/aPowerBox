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
using static aPowerDesk.DeskViewModel;

namespace aPowerDesk.View
{
	/// <summary>
	/// Interaction logic for TabPage.xaml
	/// </summary>
	public partial class TabPage : Page
	{

		//Main StartPage 
		StartTab start;

		public TabPage()
		{
			InitializeComponent();

			//Link Tab to VMTab 
			VMTab = tab;

			//Show the Startpage
			start = new StartTab(VMTab);


		}
	}
}
