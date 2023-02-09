using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookingApp.Data.Model
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        [StringLength(150, ErrorMessage = "Name is too long!")]
        public string? Name { get; set; }
    }
}
