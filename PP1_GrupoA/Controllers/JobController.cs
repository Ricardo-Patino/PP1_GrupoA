using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PP1_GrupoA.Models;

namespace PP1_GrupoA.Controllers
{
    public class JobController : Controller
    {
        private List<Job> job = new List<Job>
        {
            new Job { Id = "1", Name = "Software Developer", Description = "Writes code", DateCreated = DateTime.Now },
            new Job { Id = "2", Name = "Teacher", Description = "Teaches students", DateCreated = DateTime.Now },
            new Job { Id = "3", Name = "Doctor", Description = "Treats patients", DateCreated = DateTime.Now },
            new Job { Id = "4", Name = "Pilot", Description = "Flies planes", DateCreated = DateTime.Now },
            new Job { Id = "5", Name = "Architect", Description = "Designs buildings", DateCreated = DateTime.Now },
            new Job { Id = "6", Name = "Chef", Description = "Prepares food", DateCreated = DateTime.Now },
            new Job { Id = "7", Name = "Firefighter", Description = "Rescues people", DateCreated = DateTime.Now },
            new Job { Id = "8", Name = "Photographer", Description = "Captures moments", DateCreated = DateTime.Now },
            new Job { Id = "9", Name = "Engineer", Description = "Builds solutions", DateCreated = DateTime.Now },
            new Job { Id = "10", Name = "Artist", Description = "Creates art", DateCreated = DateTime.Now }
        };

    }
}