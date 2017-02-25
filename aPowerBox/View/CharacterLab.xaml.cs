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
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace aPowerBox.View
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class CharacterLab : Page10x
	{

		public enum SheetState {  ForntBack,FrontSide,BackSide,Front,Back,Side}
		SketchCanvas front, side, back;
		TextBlock tbFront, tbBack, tbSide;
		RowDefinition row1, row2;
		ColumnDefinition col1, col2, col3;
		SheetState state;


		public CharacterLab()
		{
			this.InitializeComponent();

			// Declare the SketchCanvas 
			front = new SketchCanvas();
			side = new SketchCanvas();
			back = new SketchCanvas();

			//Declare TextBlock 
			tbFront = new TextBlock { TextAlignment = TextAlignment.Center, Margin = new Thickness(5) };
			tbBack = new TextBlock { TextAlignment = TextAlignment.Center, Margin = new Thickness(5) };
			tbSide = new TextBlock { TextAlignment = TextAlignment.Center, Margin = new Thickness(5) };

			//Row's 
			row1 = new RowDefinition();
			row2 = new RowDefinition {  MinHeight= 40} ;

			//Column's 
			col1 = new ColumnDefinition();
			col2 = new ColumnDefinition();
			col3 = new ColumnDefinition();


		}

		public SheetState State
		{
			get
			{
				return state;
			}
			set
			{
				state = value;

				//Clear LayoutRoot
				void clear()
				{
					layoutRoot.Children.Clear();
					layoutRoot.RowDefinitions.Clear();
					layoutRoot.ColumnDefinitions.Clear();
				}


				switch(value )
				{
					case SheetState.Front:
						clear();
						  
						break;
					case SheetState.Back:
						clear();

						break;
					case SheetState.Side:
						clear();
						break;
					case SheetState.FrontSide:
						clear();

						break;
					case SheetState.ForntBack:
						clear();

						break;
					case SheetState.BackSide:
						clear();

						break;
				}

			}
		}

	}
}
