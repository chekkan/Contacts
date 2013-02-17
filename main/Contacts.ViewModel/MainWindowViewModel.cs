namespace Contacts.ViewModel
{
    public class MainWindowViewModel
    {
        public ContactListViewModel CreateContactListViewModel()
        {
            ContactListViewModel viewModel = new ContactListViewModel();
            return viewModel;
        }

        public ContactDetailsViewModel CreateContactDetailsViewModel()
        {
            ContactDetailsViewModel viewModel = new ContactDetailsViewModel(null);
            return viewModel;
        }
    }
}