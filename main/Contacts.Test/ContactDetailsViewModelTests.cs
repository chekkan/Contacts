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
            ContactDetailsViewModel viewModel = new ContactDetailsViewModel();
            Assert.IsInstanceOf<INotifyPropertyChanged>(viewModel);
        }
    }
}