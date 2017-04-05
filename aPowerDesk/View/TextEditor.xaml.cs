using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Albert.Flex.Windows;

namespace aPowerDesk.View
{
	/// <summary>
	/// Interaction logic for TextEditor.xaml
	/// </summary>
	public partial class TextEditor : DocumentControl
	{
		//Field's 
		CodeEditor txt1, txt2, txt3;
		GridSplitter split1, split2;
		ColumnDefinition col1, col2, col3,col4,col5;

		private void cmbDoc_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			var item = cmbDoc.SelectedItem as ComboBoxItem;

			switch(item.Tag)
			{
				case "One":
					State = EditorState.One;
					break;
				case "Two":
					State = EditorState.Two;
					break;
				case "Three":
					State = EditorState.Three;
					break;
			}
		}

		EditorState state;

		public TextEditor(TabControl _mainTab)
		{
			InitializeComponent();

			TabItem = new DocumentTabItem($"TextDocument{Count++}", true, this, _mainTab);
		

			//layoutRoot Logic 
			void InitLayoutRoot()
			{
				//Create the Code Editor's 
				txt1 = new CodeEditor();
				txt2 = new CodeEditor();
				txt3 = new CodeEditor();

				//Create the Grid Splitters 
				split1 = new GridSplitter();
				split2 = new GridSplitter();


				//Column Defnition 
				col1 = new ColumnDefinition();
				col2 = new ColumnDefinition { MinWidth = 10, MaxWidth = 10 };
				col3 = new ColumnDefinition();
				col4 = new ColumnDefinition { MinWidth = 10, MaxWidth = 10};
				col5 = new ColumnDefinition();

			}

			//Run the InitLayoutRoot
			InitLayoutRoot();

			//Set the Default State 
			State = EditorState.One;

			//Set the Focus
			TabItem.Focus();
			txt1.Focus();

		}


		public EditorState State
		{
			get { return state; }
			set
			{
				state = value;

				//Cleanup 
				void cleanUp()
				{
					layoutRoot.Children.Clear();
					layoutRoot.ColumnDefinitions.Clear();
				
				}

				//One Document
				void one()
				{
					//Do the cleanUp
					cleanUp();

					//Add Columns
					layoutRoot.ColumnDefinitions.Add(col1);
					
					//Fitst CodeEditor 
					Grid.SetColumn(txt1, 0);
					layoutRoot.Children.Add(txt1);

				}
				
				//Two Documents
				void two()
				{
					//Do the cleanUp
					cleanUp();

					//Add Columns
					layoutRoot.ColumnDefinitions.Add(col1);
					layoutRoot.ColumnDefinitions.Add(col2);
					layoutRoot.ColumnDefinitions.Add(col3);

					//Fitst CodeEditor 
					Grid.SetColumn(txt1, 0);
					layoutRoot.Children.Add(txt1);

					//Split Control 
					Grid.SetColumn(split1, 1);
					layoutRoot.Children.Add(split1);

					//Second CodeEidtor 
					Grid.SetColumn(txt2, 2);
					layoutRoot.Children.Add(txt2);


				}

				//Three Documents
				void three()
				{
					//Do the cleanUp 
					cleanUp();

					//Add Columns
					layoutRoot.ColumnDefinitions.Add(col1);
					layoutRoot.ColumnDefinitions.Add(col2);
					layoutRoot.ColumnDefinitions.Add(col3);
					layoutRoot.ColumnDefinitions.Add(col4);
					layoutRoot.ColumnDefinitions.Add(col5);

					//Fitst CodeEditor 
					Grid.SetColumn(txt1, 0);
					layoutRoot.Children.Add(txt1);

					//Split Control 
					Grid.SetColumn(split1, 1);
					layoutRoot.Children.Add(split1);

					//Second CodeEidtor 
					Grid.SetColumn(txt2, 2);
					layoutRoot.Children.Add(txt2);

					//Split2 Control 
					Grid.SetColumn(split2, 3);
					layoutRoot.Children.Add(split2);

					//Third CodeEidtor 
					Grid.SetColumn(txt3, 4);
					layoutRoot.Children.Add(txt3);

				}

				switch(value)
				{
					case EditorState.One:
						one(); //One Document
						break;
					case EditorState.Two:
						two(); // Two Document
						break;
					case EditorState.Three:
						three(); // Three Document 
						break;
				}
			}
		}
		
	}


	//Enume for the Modes 
	public enum EditorState { One, Two, Three }

}
