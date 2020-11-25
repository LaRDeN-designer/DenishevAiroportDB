using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AirportDateBase.Models
{
    public class Flight
    {
        public long ID { get; set; }

        [Display(Name = "Самолет")]
        public long? Plane_ID { get; set; }
        [Display(Name = "Самолет")]
        public DbSet<Plane> Planes { get; set; }

        [Display(Name = "Экипаж")]
        public long? Crew_ID { get; set; }
        [Display(Name = "Экипаж")]
        public DbSet<Crew> Crews { get; set; }

        [Display(Name = "Дата")]
        public DateTime Date { get; set; }

        [Display(Name = "Время")]
        public DateTime Time { get; set; }

        [Display(Name = "Откуда")]
        public string Departure { get; set; }

        [Display(Name = "Куда")]
        public string Arrival { get; set; }

        [Display(Name = "Время полета")]
        public string Time_flight { get; set; }
    }
}
