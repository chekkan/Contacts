using System.ComponentModel;
using Contacts.ViewModel;
using NUnit.Framework;

namespace Contacts.Test
{
    [TestFixture]
    public class ContactDetailsViewModelTests
    {
        [Test]
        public void Test_ContactDetailsViewModel_Implements_INotifyPropertyChanged()
        {
            ContactDetailsViewModel viewModel = new ContactDetailsViewModel("Fake Man");
            Assert.IsInstanceOf<INotifyPropertyChanged>(viewModel);
        }

        [Test]
        public void Test_ContactNameSet_To_Value_PassedIn()
        {
            string contactName = "Fake Name";
            ContactDetailsViewModel viewModel = new ContactDetailsViewModel(contactName);
            Assert.AreEqual(contactName, viewModel.ContactName);
        }
    }
}