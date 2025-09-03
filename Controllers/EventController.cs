using Microsoft.AspNetCore.Mvc;
using QuickEventSolutionLtdApp.Models;

namespace QuickEventSolutionLtdApp.Controllers
{
    public class EventController : Controller
    {
        public IActionResult AllEvents()
        {
            var events = GetAllEvents();
            return View(events);
            
        }
        public IActionResult UpcomingEvents() {
            var allEvents = GetAllEvents();
            var today = DateTime.Today;
            List<EventViewModel> upcomingEvents= new List<EventViewModel>();
            foreach(var ev in allEvents)
            {
                if (ev.Date > today) 
                {
                    upcomingEvents.Add(ev);
                }
            }
            return View(upcomingEvents);
        }

        private List<EventViewModel> GetAllEvents() { 
            
            List<EventViewModel> events = new List<EventViewModel>();
            EventViewModel event1 = new EventViewModel() 
            {   Id=1,
                Name = "Annual Meeting",
                Description = "Company-wide annual meeting to discuss performance and future plans.",
                Date = new DateTime(2025, 8, 25),
                Address = "123 Corporate Blvd, Business City",
                AssignedUser = "John Doe"
            };
            EventViewModel event2 = new EventViewModel()
            {
                Id=2,
                Name = "Product Launch",
                Description = "Launch event for the new product line with live demonstrations.",
                Date = new DateTime(2024, 11, 15),
                Address = "456 Innovation Dr, Tech Town",
                AssignedUser = "Jane Smith"
            };
            EventViewModel event3 = new EventViewModel()
            {
                Id=3,
                Name = "Networking Event",
                Description = "An evening of networking with industry professionals and potential clients.",
                Date = new DateTime(2025, 9, 3),
                Address = "789 Market St, Commerce City",
                AssignedUser = "Bob Johnson"
            };
            EventViewModel event4 = new EventViewModel()
            {
                Id=4,
                Name = "Training Workshop",
                Description = "A workshop focused on skill development and team building activities.",
                Date = new DateTime(2025, 9, 10),
                Address = "321 Learning Ln, Education City",
                AssignedUser = "Alice Wilson"
            };
            events.Add(event1);
            events.Add(event2);
            events.Add(event3);
            events.Add(event4);
            return events;

        }
    }
}
