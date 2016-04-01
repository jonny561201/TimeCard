using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TimeCardWeb.Controllers;
using TimeCardWeb.Models;

namespace TimeCardWeb.Tests.Controllers
{
    [TestClass]
    public class TimeEntryControllerTest
    {
        [TestMethod]
        public void ShowPage()
        {
            TimeEntryController controller = new TimeEntryController();

            ViewResult result = controller.Index() as ViewResult;

            Assert.IsNotNull(result);
        }

        //TODO: Remove duplication
        //TODO: Nunit????

        [TestMethod]
        public void SaveTimeEntryOnPost()
        {
            // Setup
            var timeEntryRepository = new FakeTimeEntryRepository();
            var controller = new TimeEntryController(timeEntryRepository);
            var model = new TimeEntryViewModel();
            model.ProjectName = "Valid Project Name";

            controller.Index(model);
            
            Assert.IsTrue(timeEntryRepository.SaveWasCalled());
        }

        [TestMethod]
        public void NoSaveWhenModelIsInvalid()
        {
            //Setup
            var timeEntryRepository = new FakeTimeEntryRepository();
            var controller = new TimeEntryController(timeEntryRepository);
            var model = new TimeEntryViewModel();
            model.ProjectName = "";

            controller.Index(model);

            Assert.IsFalse(timeEntryRepository.SaveWasCalled());
        }

    }

    // TODO: replace with mock
    public class FakeTimeEntryRepository : ITimeEntryRepository
    {
        private bool wasCalled = false;

        public void Save(TimeEntryViewModel model)
        {
            wasCalled = true;
        }

        public bool SaveWasCalled()
        {
            return wasCalled;
        }
    }
}
