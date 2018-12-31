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

namespace DucksAlive.pages
{
	/// <summary>
	/// Interaction logic for DucksAliveHome.xaml
	/// </summary>
	public partial class DucksAliveHome : Page
	{
		public DucksAliveHome()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			//View Duck Report
			DucksAliveReportPage ducksAliveReportPage = new DucksAliveReportPage(duckListBox.SelectedItem);
			NavigationService?.Navigate(ducksAliveReportPage);
		}
	}
}
