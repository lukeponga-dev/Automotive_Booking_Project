using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Automotive_Booking_Project.Models
{
    public class Users
    {
        [Key]
        public int User_Id { get; set; }

        public string Name { get; set; }

        public int Telephone { get; set; } = 0;
        public string email { get; set; }
    }
}
