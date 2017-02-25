using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Albert.Flex.Runtime; 
using static aPowerBox.PowerViewModel;
using static Albert.Flex.Runtime.Device10x;
using Windows.UI;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace aPowerBox.View
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MainView : Page10x
	{
		public MainView()
		{
			this.InitializeComponent();

			//Link to the VMFrame 
			VMFrame = frame;

			//Link to the SplitView 
			VMSplitView = splitView;

			//Navigate to the StartView 
			VMNavigate(typeof(StartView));


			//VM Notification Lamba  
			VMNotify = (_str) =>
			{
				//Link to the TextBlock tbStatus 
				tbStatus.Text = _str;
				//Create a Quick Animation 
				QuickAnimation.RunDouble(tbStatus, "Opacity", 1, .4, TimeSpan.FromSeconds(3.4));
			};


			//Set The Default Color for Title Bar 
			Device10x.TitleBarStyle((Color)App.Current.Resources["AccentColor4"], Colors.White);

			//Notify the Applicaton 
			VMNotify("Welcome to to the aPowerBox");


			

		}

		void mnu_Click(object sender, RoutedEventArgs e)
		{
			splitView.IsPaneOpen = true;
		}

		void ham_Click(object sender, RoutedEventArgs e)
		{
			var ham = sender as HamburgerButton;

			switch(ham.Symbol)
			{
				case "Ch": //Character Lab 

					break;
				case "Mp": //Map Lab 

					break;
				case "PDF": // PDF Lab

					break;

				case "Sk": //Sketch Lab 

					break;
				case "Wb": //Web Dev Lab 

					break;
				case "Wr": // Write Lab 

					break;
				default:

					break; 
			}
		}

	}
}
