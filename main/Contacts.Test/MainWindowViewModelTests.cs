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
    }
}