using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Automotive_Booking_Project.Models
{
    public class Users
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Telephone { get; set; } = 0;
        public string email { get; set; }
    }
}
