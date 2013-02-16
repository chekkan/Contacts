using Contacts.ViewModel;
using NUnit.Framework;

namespace Contacts.Test
{
    [TestFixture]
    public class ApplicationViewModelTests
    {
        [Test]
        public void Test_CreateMainWindowViewModel_ReturnsMainWindowViewModel()
        {
            ApplicationViewModel viewModel = new ApplicationViewModel();
            Assert.IsInstanceOf<MainWindowViewModel>(viewModel.CreateMainWindowViewModel());
        }
    }
}