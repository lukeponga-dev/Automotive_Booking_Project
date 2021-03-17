using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Automotive_Booking_Project.Models
{
    public class Users
    {
        //Primary key
        [Key]
        public int User_Id { get; set; }

        //Users name
        public string Name { get; set; }

        //users number
        public int Telephone { get; set; } = 0;

        //Users email
        public string email { get; set; }
    }
}
