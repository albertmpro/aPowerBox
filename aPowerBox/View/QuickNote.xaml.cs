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
using static aPowerBox.PowerViewModel;
using static Albert.Flex.Runtime.AsyncIO;
using Windows.UI.Text;
// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace aPowerBox.View
{
	public sealed partial class QuickNote : UserControl
	{
		public QuickNote()
		{
			this.InitializeComponent();

			//load click 
			btnLoad.Click += load_Click;

			// save click  
			btnSave.Click += save_Click;

		}

		async void load_Click(object sender, RoutedEventArgs e)
		{
			//Load the TextFile 
			await OpenPickerAsync(Filter, async (s) =>
			 {
				
				 var str = await ReadTextAsync(s);

				 txt.Document.SetText(TextSetOptions.None, str);


			 });

		}

		async void save_Click(object sender, RoutedEventArgs e)
		{
			var str = "";
			txt.Document.GetText(Windows.UI.Text.TextGetOptions.None, out str);
			await ExportTextAsync(str);

		}


	}
}
