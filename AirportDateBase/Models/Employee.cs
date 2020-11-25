using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AirportDateBase.Models
{
    public class Employee
    {
        public long ID { get; set; }

        [Display(Name ="Должность")]
        public long? Posts_ID { get; set; }
        [Display(Name = "Должность")]
        public DbSet<Posts> Posts { get; set; }

        [Display(Name = "ФИО")]
        public string FIO { get; set; }

        [Display(Name = "Возраст")]
        public int Age { get; set; }

        [Display(Name = "Пол")]
        public string Gender { get; set; }

        [Display(Name = "Адрес")]
        public string Adress { get; set; }

        [Display(Name = "Телефон")]
        public string Telephone { get; set; }

        [Display(Name = "Паспорт")]
        public string Pasport_data { get; set; }
    }
}
