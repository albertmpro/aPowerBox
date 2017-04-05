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


namespace aPowerDesk.View
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainShell : ViewShell
	{

		//Field's 

		//TabPage of the Application 
		public TabPage tabPage = new TabPage();

		public MainShell()
		{
			InitializeComponent();




			frame.Navigate(tabPage);


			#region Commands

			var newWindow = new NewWindow();


			Grid.SetRowSpan(newWindow, 3);
			layoutRoot.Children.Add(newWindow);


			void new_Command(object sender, ExecutedRoutedEventArgs e)
			{

				//Show the New Window 
				newWindow?.Show();

			}

			void quit_Command(object sender, ExecutedRoutedEventArgs e)
			{
				Close();
			}



			//Link Commands here 
			CommandBindings.Add(new CommandBinding(DesktopCommands.Quit, quit_Command));

			CommandBindings.Add(new CommandBinding(ApplicationCommands.New, new_Command));

			#endregion


		}


	}
}
