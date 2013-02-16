using System.Collections.Generic;
using System.ComponentModel;

namespace Contacts.ViewModel
{
    public class ContactListViewModel : INotifyPropertyChanged
    {
        private IList<string> contactNames;
        
        public event PropertyChangedEventHandler PropertyChanged;

        public IList<string> ContactNames
        {
            get { return contactNames; }
            set
            {
                if (contactNames != value)
                {
                    contactNames = value;
                    OnPropertyChanged("ContactNames");
                }
            }
        }

        public ContactListViewModel()
        {
        }

        private void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}