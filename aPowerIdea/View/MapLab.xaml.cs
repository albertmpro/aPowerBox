using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Albert.Flex.Runtime;
using Windows.Graphics.Display;
using Windows.Phone.UI.Input;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace aPowerIdea.View
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MapLab : Page10x
	{
		public MapLab()
		{
			this.InitializeComponent();
		}

		protected override void OnNavigatedTo(NavigationEventArgs e)
		{
			base.OnNavigatedTo(e);
			HardwareButtons.BackPressed += On_PhoneGoBack;
		}

		protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
		{
			base.OnNavigatingFrom(e);
			HardwareButtons.BackPressed -= On_PhoneGoBack;
		}



		private void cmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			switch (cmb.SelectedIndex)
			{
				case 0:
					map.Style = MapStyle.Aerial;
					break;
				case 1:
					map.Style = MapStyle.AerialWithRoads;
					break;
				case 2:
					map.Style = MapStyle.Aerial3D;
					break;
				case 3:
					map.Style = MapStyle.Aerial3DWithRoads;

					break;
				case 4:
					map.Style = MapStyle.Road;
					break;
				case 5:
					map.Style = MapStyle.Terrain;
					break;
				case 6:
					map.Style = MapStyle.None;
					break;
			}
		}

		async void btnFind_Click(object sender, RoutedEventArgs e)
		{
			// Set your current location.
			var accessStatus = await Geolocator.RequestAccessAsync();
			switch (accessStatus)
			{
				case GeolocationAccessStatus.Allowed:

					// Get the current location.
					Geolocator geolocator = new Geolocator();
					Geoposition pos = await geolocator.GetGeopositionAsync();
					Geopoint myLocation = pos.Coordinate.Point;

					// Set the map location.
					map.Center = myLocation;
					map.ZoomLevel = 25;
					map.LandmarksVisible = true;
					break;

				case GeolocationAccessStatus.Denied:
					// Handle the case  if access to location is denied.
					break;

				case GeolocationAccessStatus.Unspecified:
					// Handle the case if  an unspecified error occurs.
					break;
			}
		}



	}
}
