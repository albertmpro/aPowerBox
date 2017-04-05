using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICSharpCode.AvalonEdit;
using System.Windows;
using System.IO;
using static System.IO.File;
using static Albert.Flex.Windows.Win32IO;
using Albert.Flex.Windows;
using System.Windows.Input;
namespace aPowerDesk
{
	public class CodeEditor : TextEditor
	{
		
		
		/// <summary>
		/// Default Constructor 
		/// </summary>
		public CodeEditor()
		{


			#region Command Logic 
			//New Command
			void new_Command(object sender, ExecutedRoutedEventArgs e)
			{
				var msg = MessageBox.Show("Do you want to start a new document?", "New Document", MessageBoxButton.YesNo, MessageBoxImage.Asterisk);

				switch (msg)
				{
					case MessageBoxResult.Yes:
						Text = "";
						break;
					case MessageBoxResult.No:
						//Do nothing 
						break;
				}
			}

			var fitler = "All Formats(.)|*.*";

			//Open Command 
			void open_Command(object sender, ExecutedRoutedEventArgs e)
			{
				OpenDialogTask("Open Text File", fitler, (o) =>
				  {
					  //Read Text File 
					  Text = ReadAllText(o.FileName);

				  });
			}


			//Save Command 
			void save_Command(object sender, ExecutedRoutedEventArgs e)
			{
				switch (FileInfo)
				{
					default:
						//Save the -
						WriteAllText(FileInfo?.FullName, Text);
						break;
					case null:
						SaveDialogTask("Save Text File", fitler, (s) =>
						  {
							  //Setup the FileInfo 
							  FileInfo = new FileInfo(s.FileName);
							  //Write the File 
							  WriteAllText(s.FileName, Text);
						  });
						break;
				}


			}


			void saveas_Command(object sender, ExecutedRoutedEventArgs e)
			{
				SaveDialogTask("Save Text File", fitler, (s) =>
				{
					//Setup the FileInfo 
					FileInfo = new FileInfo(s.FileName);
					//Write the File 
					WriteAllText(s.FileName, Text);
				});
			}

			//Insert the Commands 

			//New Command 
			CommandBindings.Add(new CommandBinding(ApplicationCommands.New, new_Command)); 

		//Open Command 
			CommandBindings.Add(new CommandBinding(ApplicationCommands.Open, open_Command));
			//Save Command 
			CommandBindings.Add(new CommandBinding(ApplicationCommands.Save, save_Command));

			//SaveAs Command 
			CommandBindings.Add(new CommandBinding(DesktopCommands.SaveAs, saveas_Command));


			#endregion

	



		}



		/// <summary>
		/// Gets or sets the Current File that will be save 
		/// </summary>
		public FileInfo FileInfo { get; set; }


	}
}
