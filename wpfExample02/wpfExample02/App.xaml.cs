using System.Configuration;
using System.Data;
using System.Windows;
using wpfExample02.Views;

namespace wpfExample02
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		private void Application_Startup(object sender, StartupEventArgs e)
		{
			MainWindow main = new();
			main.ShowDialog();
        }
    }

}
