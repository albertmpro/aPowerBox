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
	/// Interaction logic for ThemeLab.xaml
	/// </summary>
	public partial class ThemeLab : DocumentControl
	{
		public ThemeLab(TabControl _tab)
		{

			InitializeComponent();

			TabItem = new DocumentTabItem($"Theme{Count++}", true, this, _tab);

		}


	}
}
