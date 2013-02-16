namespace Contacts.ViewModel
{
    public class MainWindowViewModel
    {
        public ContactListViewModel CreateContactListViewModel()
        {
            ContactListViewModel viewModel = new ContactListViewModel();
            return viewModel;
        }
    }
}