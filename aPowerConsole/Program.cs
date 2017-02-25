using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Albert.Flex;
using Albert.Flex.Windows;
using static System.IO.File;
using static Albert.Flex.Windows.ConsoleApp;
using static Albert.Flex.Windows.Win32IO;
using static System.Console;

using static Albert.Flex.Documents;
namespace aPowerConsole
{
	class Program
	{
		[STAThread] // For COM realated things  
		static void Main(string[] args)
		{
			//Startup of The Program 
			void start()
			{
				Clear(); // Clear the Console 
				var line = "------------------------";
				WriteLine("aPowerConsole");
				WriteLine(line);
				WriteLine("Options");
				WriteLine(line);
				WriteLine("File Exporter = exp\nWordPress = wp\nWeb = web\nAbout = about\nExit = exit");
				WriteLine(line);

				Write("Type your choice: ");
				var myinput = ReadLine();

				switch (myinput)
				{
					case "wp":
						//Run WP
						wp();
						break;
					case "exit":
						WriteLine("We are done, Goodbye!");
						WriteLine("Bye!!!");
						break;
					default:
						start(); 
						break;
				}
					

				
			
			}

			//WOrdPress Menu
			void wp()
			{
				CreateLogic("WordPress", wp, start, () =>
				   {
					   WriteLine("Options\nWordPress Theme = th\nWordPress Plugin= pn\n");
					   Write("Type your option here:");
					   var opt = ReadLine(); 

					   switch(opt)
					   {
						   case "th":
							   //Run wptheme 
							   wptheme();
							   break;
						   case "pn":
							   //Run wpplugin 
							   wpplugin();
							   break;
						   default:
							   //Go to Exit or start again 
							   ExitProgram(wp, start);
							   break;
					   }
					  
				   });
			}

			//WordPress Theme 
			void wptheme()
			{
				CreateLogic("Create a WordPress Theme Folder" ,wptheme, start, () =>
				  {
					  var name = "";
					  var author = "";
					  var version = "";
					  Write("Name:");
					  name = ReadLine();
					  Write("Author:");
					  author = ReadLine();
					  Write("Version:");
					  version = ReadLine();

					  var fb = new FolderBrowser(true);

					  if (fb.DirectoryInfo == null)
						  ExitProgram(wptheme, start);


					  var directory = fb.DirectoryInfo; //Grab the selected folder 

					  // Create a theme directory 
					  var td = directory.CreateSubdirectory(name); // Theme Directory Created 

					  //Create some sub folders 
					  var img = td.CreateSubdirectory("images"); // Images folder 
					  var js = td.CreateSubdirectory("js"); // JavasScript folder 
					  var sy = td.CreateSubdirectory("style");// style folder

				

					  //Write the StyleSheet 
					  WriteAllText("style.css", WPStyle(name, author, version));


					  // Create the theme folder 																													   
					  CopyTextFileFromFile("jquery.js", js.FullName, "jquery.js"); // Write a JQuery File
					  CopyTextFileFromFile("albert.js", js.FullName, "albert.js"); // Write alebrt.js
					  CopyTextFileFromFile("apage.js", js.FullName, "apage.js"); // Write aPage.js
					  CopyTextFileFromFile("jalbert.js", js.FullName, "jalbert.js"); // Write jAlbert.js
					  CopyTextFileFromFile("flex.scss", sy.FullName, "flex.scss"); // Write flex.scss
					  CopyTextFileFromFile("flexui.scss", sy.FullName, "flexui.scss"); // Write flex.scss

					  CopyTextFileFromFile("style.css", td.FullName, "style.scss"); // Write style.scss
					  CopyTextFileFromFile("style.css", td.FullName, "style.css"); // Write style.css
					  CopyTextFileFromFile("wpindex.php", td.FullName, "index.php"); // Write index.php
					  CopyTextFileFromFile("wpheader.php", td.FullName, "header.php"); //Write header.php
					  CopyTextFileFromFile("wpfooter.php", td.FullName, "footer.php"); //Write footer.php
					  CopyTextFileFromFile("wpcontent.php", td.FullName, "content.php"); // Write content.php;
					  CopyTextFileFromFile("wppage.php", td.FullName, "page.php"); //Write page.php;
					  CopyTextFileFromFile("wpfunctions.php", td.FullName, "functions.php"); //Write functions.php;

					  WriteLine("All files have been written...");
					  // Go to the exit program 
					  ExitProgram(wptheme, start);









				  });
			}

			//WordPress Plugin 
			void wpplugin()
			{
				CreateLogic("Create a WordPress Plugin Folder", wpplugin, start, () =>
				{
					//Type in the information 
					Write("Name: "); // Name of the Plugin
					var name = ReadLine();
					Write("Aurthor: "); // Author of the Plugin
					var author = ReadLine();
					Write("Version: "); // Version of the Plugin 
					var version = ReadLine();
					Write("License: "); // Lincense of the Plugin 
					var license = ReadLine();

					//Find the WordPress Themes folder to place it in 
					var f = new FolderBrowser(true);


					if (f.DirectoryInfo == null)
						ExitProgram(wpplugin, start);

					var directory = f.DirectoryInfo;
					// Create the Plugin Directory 
					var td = directory.CreateSubdirectory(name); // Theme Directory Created 
																 //Add Sub Folder's to the Directory 
					var img = td.CreateSubdirectory("images"); // Images folder 
					var js = td.CreateSubdirectory("js"); // JavasScript folder 
					var sy = td.CreateSubdirectory("style");// style folder

					//Add to the them directory 
					//File dump 
					var plugininfo = $"<?php\n\n/*\nPlugin Name: {name}\nAuthor: {author}\nVersion: {version}\nLicense: {license}\n\n?>"; // Let WordPress know
																																		  //Write style.css and style.scss
					WriteAllText("functions.php", plugininfo);

					// Create the theme folder 																													   
					CopyTextFileFromFile("jquery.js", js.FullName, "jquery.js"); // Write a JQuery File
					CopyTextFileFromFile("albert.js", js.FullName, "albert.js"); // Write alebrt.js
					CopyTextFileFromFile("apage.js", js.FullName, "apage.js"); // Write aPage.js
					CopyTextFileFromFile("jalbert.js", js.FullName, "jalbert.js"); // Write jAlbert.js
					CopyTextFileFromFile("flex.scss", sy.FullName, "flex.scss"); // Write flex.scss
					CopyTextFileFromFile("flexui.scss", sy.FullName, "flex.scss"); // Write flex.scss
					CopyTextFileFromFile("gwfonts.scss", sy.FullName, "gwfonts.scss"); // Write gwfonts
					CopyTextFileFromFile("style.scss", td.FullName, "style.scss"); // Write style.scss
					CopyTextFileFromFile("style.scss", td.FullName, "style.css"); // Write style.css
					CopyTextFileFromFile("wpfunctions.php", td.FullName, "functions.php"); //Write functions.php;

					WriteLine("All files have ben written...");
					// Go to the exit program 
					ExitProgram(wpplugin, start);
				});
			}
			

			//Run Start 
			start();
			
		
		   

		}



	}
}
