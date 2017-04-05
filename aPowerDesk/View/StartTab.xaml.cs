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
using Albert.Flex.Windows;
using static aPowerDesk.DeskViewModel;
namespace aPowerDesk.View
{
	/// <summary>
	/// Interaction logic for StartTab.xaml
	/// </summary>
	public partial class StartTab : DocumentControl
	{
		public StartTab(TabControl _tab)
		{
			InitializeComponent();

			//Create the TabItem
			TabItem = new DocumentTabItem("Start Page",false,this,_tab);
		}

		void link_Click(object sender, RoutedEventArgs e)
		{
			var hyp = sender as Hyperlink;

			switch(hyp.Tag)
			{
				case "txt":
					var txt = new TextEditor(VMTab);
					break;
				case "theme":
					var theme = new ThemeLab(VMTab);
					break;
			}
		}




	}
}
