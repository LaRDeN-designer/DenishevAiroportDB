using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AirportDateBase.Models
{
    public class Posts
    {
        public long ID { get; set; }

        [Display(Name = "Наименование должости")]
        public string Name_Post { get; set; }

        [Display(Name = "Требования")]
        public string Request { get; set; }

        [Display(Name = "Обязанности")]
        public string Charge { get; set; }

        [Display(Name = "Оклад")]
        public string Salary { get; set; }
    }
}
