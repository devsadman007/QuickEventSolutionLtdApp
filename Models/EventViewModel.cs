namespace QuickEventSolutionLtdApp.Models
{
    public class EventViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Address { get; set; }
        public string AssignedUser { get; set; }
    }
}
