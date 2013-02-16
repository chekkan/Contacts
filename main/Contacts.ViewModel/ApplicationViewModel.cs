namespace Contacts.ViewModel
{
    public class ApplicationViewModel
    {
        public MainWindowViewModel CreateMainWindowViewModel()
        {
            MainWindowViewModel viewModel = new MainWindowViewModel();
            return viewModel;
        }
    }
}