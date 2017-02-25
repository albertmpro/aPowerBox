﻿using System;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace aPowerBox.View
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class StartView : Page10x
	{
		public StartView()
		{
			this.InitializeComponent();
		}

		void hyperlink_Click(object sender, RoutedEventArgs e)
		{
			var hype = sender as HyperlinkButton;

			switch (hype.Tag)
			{
				case "character":

					break;
				case "map":

					break;
				case "pdf":

					break;
				case "sketch":

					break;
				case "theme":

					break;
				case "web":

					break;
				case "writer":

					break;
				default:

					break;
			}


		}

	}
}