using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AirportDateBase.Models
{
    public class Plane
    {
        public long ID { get; set; }

        [Display(Name = "Тип")]
        public long? Type_ID { get; set; }
        [Display(Name = "Тип")]
        public DbSet<Type_plane> Types { get; set; }

        [Display(Name = "Сотрудник")]
        public long? Employee_ID { get; set; }
        [Display(Name = "Сотрудник")]
        public DbSet<Employee> Employees { get; set; }

        [Display(Name = "Марка")]
        public string Mark { get; set; }

        [Display(Name = "Вместимость")]
        public int Capacity { get; set; }

        [Display(Name = "Грузоподъемность")]
        public int Tonnage { get; set; }

        [Display(Name = "Технические характеристики")]
        public string Technical_parameters { get; set; }

        [Display(Name = "Дата выпуска")]
        public DateTime Release_date { get; set; }

        [Display(Name = "Дата последнего ремонта")]
        public DateTime Date_last_repair { get; set; }

        [Display(Name = "Налетано часов")]
        public string Hours_flown { get; set; }
    }
}
