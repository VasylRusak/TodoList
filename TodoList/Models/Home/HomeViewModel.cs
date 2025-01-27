using System.ComponentModel.DataAnnotations;
using TodoList.Domain.Entities;

namespace TodoList.Models.Home
{
    public class HomeViewModel
    {
        [Required(ErrorMessage ="This field is required")]
        public string TaskName { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public DateTime? DateTime { get; set; }
        public IEnumerable<TaskApp>? Tasks { get; set; }
    }
}
