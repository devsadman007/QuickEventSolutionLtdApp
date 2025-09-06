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
            EventViewModel event5 = new EventViewModel()
            {
                Id = 5,
                Name = "Charity Gala",
                Description = "Fundraising gala dinner to support local community projects.",
                Date = new DateTime(2025, 10, 5),
                Address = "555 Harmony Ave, Unity Town",
                AssignedUser = "Michael Brown"
            };

            EventViewModel event6 = new EventViewModel()
            {
                Id = 6,
                Name = "Board Meeting",
                Description = "Quarterly meeting with board members to review strategic goals.",
                Date = new DateTime(2024, 10, 15),
                Address = "100 Leadership Rd, Capital City",
                AssignedUser = "Sarah Lee"
            };

            EventViewModel event7 = new EventViewModel()
            {
                Id = 7,
                Name = "Customer Appreciation Day",
                Description = "Special event to thank loyal customers with discounts and activities.",
                Date = new DateTime(2025, 11, 2),
                Address = "200 Service St, Client City",
                AssignedUser = "David Green"
            };

            EventViewModel event8 = new EventViewModel()
            {
                Id = 8,
                Name = "Tech Conference",
                Description = "Annual technology conference featuring keynote speakers and exhibitions.",
                Date = new DateTime(2024, 11, 20),
                Address = "900 Future Blvd, Silicon Valley",
                AssignedUser = "Emily Davis"
            };

            EventViewModel event9 = new EventViewModel()
            {
                Id = 9,
                Name = "Holiday Party",
                Description = "End-of-year holiday celebration for employees and their families.",
                Date = new DateTime(2024, 12, 18),
                Address = "777 Celebration Rd, Festive Town",
                AssignedUser = "Chris Martin"
            };

            EventViewModel event10 = new EventViewModel()
            {
                Id = 10,
                Name = "Health & Wellness Fair",
                Description = "A fair promoting health awareness with free check-ups and fitness sessions.",
                Date = new DateTime(2026, 1, 12),
                Address = "150 Wellness St, Healthy City",
                AssignedUser = "Olivia White"
            };

            events.Add(event1);
            events.Add(event2);
            events.Add(event3);
            events.Add(event4);
            events.Add(event5);
            events.Add(event6);
            events.Add(event7);
            events.Add(event8);
            events.Add(event9);
            events.Add(event10);
            return events;

        }
    }
}
