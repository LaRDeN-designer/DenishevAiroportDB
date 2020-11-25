using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AirportDateBase.Models
{
    public class Crew
    {
        public long ID { get; set; }

        [Display(Name = "Сотрудник 1")]
        public long? Employee_1ID { get; set; }
        [Display(Name = "Сотрудник 1")]
        public DbSet<Employee> Employees_1ID { get; set; }

        [Display(Name = "Сотрудник 2")]
        public long? Employee_2ID { get; set; }
        [Display(Name = "Сотрудник 2")]
        public DbSet<Employee> Employees_2ID { get; set; }

        [Display(Name = "Сотрудник 3")]
        public long? Employee_3ID { get; set; }
        [Display(Name = "Сотрудник 3")]
        public DbSet<Employee> ID_Employees_3 { get; set; }

        [Display(Name = "Налетано часов")]
        public int Hours_flown { get; set; }
    }
}