using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Automotive_Booking_Project.Models
{
    public class BookingReason
    {
       // Primary key
        [Key]
        public int BookingReason_Id { get; set; }

        // Booking Reason
        public string reason { get; set; }



    }
}
