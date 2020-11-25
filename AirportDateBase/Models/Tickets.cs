using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AirportDateBase.Models
{
    public class Tickets
    {
        public long ID { get; set; }

        [Display(Name = "ФИО пассажира")]
        public string Name_passenger { get; set; }

        [Display(Name = "Паспортные данные")]
        public string Pasport_Date { get; set; }

        [Display(Name = "Место")]
        public string Room { get; set; }

        [Display(Name = "Цена")]
        public string Price { get; set; }

        [Display(Name = "Рейс")]
        public long? Flight_ID { get; set; }
        [Display(Name = "Рейсы")]
        public DbSet<Flight> Flights { get; set; }
    }
}
