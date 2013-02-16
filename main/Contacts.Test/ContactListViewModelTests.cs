using System.Collections.Generic;
using System.ComponentModel;
using Contacts.ViewModel;
using NUnit.Framework;

namespace Contacts.Test
{
    [TestFixture]
    public class ContactListViewModelTests
    {
        [Test]
        public void Test_ContactListViewModel_Implements_INotifyPropertyChanged()
        {
            ContactListViewModel viewModel = new ContactListViewModel();
            Assert.IsInstanceOf<INotifyPropertyChanged>(viewModel);
        }

        [Test]
        public void Test_ContactNames_IList_Raises_OnPropertyChanged_Event()
        {
            bool handled = false;
            ContactListViewModel viewModel = new ContactListViewModel();
            viewModel.PropertyChanged += (s, e) => { handled = true; };
            viewModel.ContactNames = new List<string>();
            Assert.IsTrue(handled);
        }
    }
}