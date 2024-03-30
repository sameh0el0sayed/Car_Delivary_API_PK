namespace Car_Delivary_API.Modals
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Location
    {
        [Key]
        public int LocationID { get; set; }
  
        public int Latitude { get; set; } = 0;
        public int Longitude { get; set; } = 0;

        [MinLength(100)]
        public string LandmarkAddress { get; set; } = string.Empty;
        public string LandmarkName { get; set; } = string.Empty;
        public string LandmarkCity { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
    }
}
