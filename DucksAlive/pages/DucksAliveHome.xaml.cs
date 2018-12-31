using System.Windows;
using System.Windows.Controls;

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
