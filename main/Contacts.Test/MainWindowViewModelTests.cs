using Contacts.ViewModel;
using NUnit.Framework;

namespace Contacts.Test
{
    [TestFixture]
    public class MainWindowViewModelTests
    {
        [Test]
        public void Test_CreateContactListViewModel_Returns_ContactListViewModel()
        {
             MainWindowViewModel viewModel = new MainWindowViewModel();
            Assert.IsInstanceOf<ContactListViewModel>(viewModel.CreateContactListViewModel());
        }

        [Test]
        public void Test_CreateContactDetailsViewModel_Returns_ContactDetailsViewModel()
        {
            MainWindowViewModel viewModel = new MainWindowViewModel();
            Assert.IsInstanceOf<ContactDetailsViewModel>(viewModel.CreateContactDetailsViewModel());
        }
    }
}