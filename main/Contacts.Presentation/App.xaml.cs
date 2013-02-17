using System.Windows;
using Contacts.ViewModel;

namespace Contacts.Presentation
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            // create mainWindowViewModel
            ApplicationViewModel viewModel = new ApplicationViewModel();
            MainWindowViewModel mainWindowViewModel = viewModel.CreateMainWindowViewModel();

            MainWindow mainWindow = new MainWindow();

            // create contactListViewModel
            ContactListViewModel contactListViewModel = mainWindowViewModel.CreateContactListViewModel();

            // create contactDetailsViewModel
            ContactDetailsViewModel contactDetailsViewModel = mainWindowViewModel.CreateContactDetailsViewModel();

            mainWindow.contactListView1.DataContext = contactListViewModel;

            mainWindow.contactDetailsView1.DataContext = contactDetailsViewModel;
            
            mainWindow.DataContext = mainWindowViewModel;

            this.MainWindow = mainWindow;

            this.MainWindow.Show();
        }
    }
}
