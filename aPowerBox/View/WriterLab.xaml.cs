using Albert.Flex.Runtime;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using static Albert.Flex.Runtime.Device10x;
using static aPowerBox.PowerViewModel;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace aPowerBox.View
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class WriterLab : Page10x
	{
		public WriterLab()
		{
			this.InitializeComponent();
		}

		async void cmd_Click(object sender, RoutedEventArgs e)
		{
			var cmd = sender as CmdButton; 


			void newDoc()
			{
				// Empty the Document 
				txt.Document.SetText(Windows.UI.Text.TextSetOptions.None, "");
				VMNotify("You have created a new Docment.");
			}
			async void saveDoc()
			{
				var str = "";
				//Get the Text 
				txt.Document.GetText(TextGetOptions.None, out str);

				//Write the File here
				await AsyncIO.SaveTextAsync("TextDocument.txt",str);
			}

			switch(cmd.Label)
			{
				case "New":
					await MsgShow("New Document", "Do you want to create a new document?", "New","Cancel",newDoc);
					break;
				case "Save":
					await MsgShow("Save Document", "Do you want to save a this document?", "Save","Cancel",saveDoc);
					break;
			}
		}



	}
}
