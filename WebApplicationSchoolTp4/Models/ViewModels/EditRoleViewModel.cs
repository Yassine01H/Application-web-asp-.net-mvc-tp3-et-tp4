using System.ComponentModel.DataAnnotations;

namespace WebApplicationSchoolTp4.Models.ViewModels
{
    public class EditRoleViewModel
    {
        public EditRoleViewModel()
        {
            Users = new List<string>();
        }
        public string Id { get; set; }
        [Required(ErrorMessage = "Role Name is required")]
        public string RoleName { get; set; }
        public List<string> Users { get; set; }
    }
}
