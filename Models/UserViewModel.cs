using QuickEventSolutionLtdApp.Utils;

namespace QuickEventSolutionLtdApp.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? ContactNumber { get; set; }
        public string? Email { get; set; }
        public UserTypeEnum UserType { get; set; }

    }
}
