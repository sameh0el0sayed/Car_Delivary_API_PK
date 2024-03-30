namespace Car_Delivary_API.Modals
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Trip
    {
        [Key]
        [Required] public int TripID { get; set; }
        [Required] public int CustomerID { get; set; }
        [Required] public int DriverID { get; set; }
        [Required] public int CarID { get; set; }
        public DateTime TripRequestedTimestamp { get; set; }    = DateTime.Now;
        public DateTime TripStartTimestamp { get; set; } = DateTime.Now;
        public DateTime TripEndTimestamp { get; set; } = DateTime.Now;
        public int TripWaitTime { get; set; }
        [Required] public int StartLocationID { get; set; }
        [Required] public int EndLocationID { get; set; }
        public int DriverRating { get; set; }   =   0;
        public int CustomerRating { get; set; } = 0;
        public int PaymentID { get; set; }
        public int TripStatus { get; set; }

   
   
    }
}
