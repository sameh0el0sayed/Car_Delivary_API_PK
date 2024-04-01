namespace Car_Delivary_API.Modals
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Trip
    {
        [Key]
        [Required]
        [MaxLength(50)]
        public string TripID { get; set; } = Guid.NewGuid().ToString();
        [Required]
        [MaxLength(50)]
        public string UserId { get; set; }
        [Required]
        [MaxLength(50)]
        public string DriverID { get; set; }
        [Required]
        [MaxLength(50)]
        public string VehicleID { get; set; }
        public DateTime TripRequestedTimestamp { get; set; }    = DateTime.Now;
        public DateTime TripStartTimestamp { get; set; } = DateTime.Now;
        public DateTime TripEndTimestamp { get; set; } = DateTime.Now;
        public int TripWaitTime { get; set; }
        [Required] 
        public int StartLocationID { get; set; }
        [Required]
        public int EndLocationID { get; set; }
        public int DriverRating { get; set; }   =   0;
        public int UserRating { get; set; } = 0;
        public int PaymentID { get; set; }
        public int TripStatus { get; set; }

   
   
    }
}
