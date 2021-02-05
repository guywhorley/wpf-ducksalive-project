using System;

namespace DucksAlive.pages
{
	/// <summary>
	/// Interaction logic for DucksAliveReportPage.xaml
	/// </summary>
	public partial class DucksAliveReportPage
	{
		public DucksAliveReportPage(object data) : this() =>
			DataContext = data ?? throw new ArgumentNullException(nameof(data));

		public DucksAliveReportPage()
		{
			InitializeComponent();
		}
	}
}
