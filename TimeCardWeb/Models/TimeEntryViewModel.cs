using System.ComponentModel.DataAnnotations;
using Microsoft.Ajax.Utilities;

namespace TimeCardWeb.Models
{
    public class TimeEntryViewModel
    {
        [Required]
        [Display(Name = "Project Name")]
        public string ProjectName {get; set;}

        public bool IsValid()
        {
            // We need a test for this
            return !ProjectName.IsNullOrWhiteSpace();
        }
    }
}