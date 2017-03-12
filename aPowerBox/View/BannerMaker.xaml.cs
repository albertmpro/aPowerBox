using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using static Albert.Flex.Runtime.AsyncIO;
using static Albert.Flex.Runtime.Device10x;
using static aPowerBox.PowerViewModel;
// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace aPowerBox.View
{
	public sealed partial class BannerMaker : UserControl
	{
		public BannerMaker()
		{
			this.InitializeComponent();
		}

		private void slideP_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
		{
			var slide = sender as Slider;

			switch (slide.Tag)
			{
				case "width":
					img.Width = slide.Value;
					break;
			    case "height":
					img.Height = slide.Value;
					break;
			}



		}

		async void PushButton_Click(object sender, RoutedEventArgs e)
		{
			//Load the Picture Lamba 
			await OpenPictureAsync(img);
		}
		private void cmbImageType_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			var item = (ComboBoxItem)cmbImageType.SelectedItem;
			if(item != null)
			{
				switch (item.Content)
				{
					case "None":
						img.Stretch = Stretch.None;
						break;
					case "Fill":
						img.Stretch = Stretch.Fill;
						break;
					case "Uniform":
						img.Stretch = Stretch.Uniform;
						break;
					case "UniformToFill":
						img.Stretch = Stretch.UniformToFill;
						break;

				}
			}



		}

		private async void btnExport_Click(object sender, RoutedEventArgs e)
		{
			async  void export()
			{
				await ExportJpegAsync(gridImg, 72);
				//Notify 
				VMNotify("Image has been exported");
			}

			await MsgShow("Export", "Do want to export this banner?", "Export", "Cancel", export);
			
		}
	}
}
