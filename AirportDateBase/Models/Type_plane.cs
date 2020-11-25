using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AirportDateBase.Models
{
    public class Type_plane
    {
        public long ID { get; set; }

        [Display(Name = "Имя самолета")]
        public string Name_plane { get; set; }

        [Display(Name = "Ограничения")]
        public string Limit { get; set; }

        [Display(Name = "Назначение")]
        public string Purpose { get; set; }
    }
}