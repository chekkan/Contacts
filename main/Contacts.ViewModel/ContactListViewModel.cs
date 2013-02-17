using System.Collections.Generic;
using System.ComponentModel;

namespace Contacts.ViewModel
{
    public class ContactListViewModel : ViewModelBase
    {
        private IList<string> contactNames;
        
        public IList<string> ContactNames
        {
            get { return contactNames; }
            set
            {
                if (contactNames != value)
                {
                    contactNames = value;
                    RaisePropertyChanged("ContactNames");
                }
            }
        }
    }
}