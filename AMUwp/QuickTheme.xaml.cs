using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace AMUwp
{
	public sealed partial class QuickTheme : UserControl
	{
		public QuickTheme()
		{
			this.InitializeComponent();

			//Main Logic for the ColorPicker 
			void cpicker(Color c)
			{
				var brush = new SolidColorBrush(c);
				
				if (opt1.IsChecked == true)
				{
			
					opt1.BorderBrushChecked = brush;
					opt1.Background = brush; 

				}
				else if(opt2.IsChecked == true)
				{
			
					opt2.BorderBrushChecked = brush;
					opt2.Background = brush;
				}
				else if (opt3.IsChecked == true)
				{
			
					opt3.BorderBrushChecked = brush;
					opt3.Background = brush;
				}
				else if (opt4.IsChecked == true)
				{
				
					opt4.BorderBrushChecked = brush;
					opt4.Background = brush;
				}
				else if (opt5.IsChecked == true)
				{
					opt5.BorderBrushChecked = brush;
					opt5.Background = brush;
				}
			}
			//Create ColorPicker Change Functon 
			colorPicker.OnColorChanged += cpicker;
			
		}
	}
}
