using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Automotive_Booking_Project.Models
{
    public class bookings
    {
        //Primary Key
        public int Id { get; set; }

        //Foreign key for users
        public int User_Id { get; set; }
        public Users Users { get; set; }
       
        //Foreign key for reason
        public int BookingReason_Id { get; set; }
        public BookingReason BookingReason { get; set; }

        //Foreign key for staff
        public int staff_Id { get; set; }
        public Staff Staff { get; set; }
    }
}
