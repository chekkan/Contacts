namespace Contacts.ViewModel
{
    public class ContactDetailsViewModel : ViewModelBase
    {
        private string contactName;

        public string ContactName
        {
            get { return contactName; }
            set
            {
                if (contactName != value)
                {
                    contactName = value;
                    RaisePropertyChanged("ContactName");
                }
            }
        }

        public ContactDetailsViewModel(string contactName)
        {
            ContactName = contactName;
        }
    }
}