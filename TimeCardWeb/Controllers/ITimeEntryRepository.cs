using TimeCardWeb.Models;

namespace TimeCardWeb.Controllers
{
    public interface ITimeEntryRepository
    {
        void Save(TimeEntryViewModel model);
    }
}