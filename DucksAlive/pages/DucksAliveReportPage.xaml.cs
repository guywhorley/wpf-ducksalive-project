using System.Windows.Controls;

namespace DucksAlive.pages
{
	/// <summary>
	/// Interaction logic for DucksAliveReportPage.xaml
	/// </summary>
	public partial class DucksAliveReportPage : Page
	{
		public DucksAliveReportPage(object data) : this()
		{
			DataContext = data;
		}

		public DucksAliveReportPage()
		{
			InitializeComponent();
		}
	}
}
