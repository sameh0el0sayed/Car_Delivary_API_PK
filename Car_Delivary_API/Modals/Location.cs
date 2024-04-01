namespace Car_Delivary_API.Modals
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Location
    {
        [Key]
        [MaxLength(50)]
        public string LocationID { get; set; } = Guid.NewGuid().ToString();
        [MaxLength(20)]
        public string Latitude { get; set; } = string.Empty;
        [MaxLength(20)]
        public string Longitude { get; set; } = string.Empty;

        [MinLength(100)]
        public string LandmarkAddress { get; set; } = string.Empty;
        [MaxLength(20)]
        public string LandmarkName { get; set; } = string.Empty;
        [MaxLength(20)]
        public string LandmarkCity { get; set; } = string.Empty;
        [MaxLength(20)]
        public string Country { get; set; } = string.Empty; 
        public bool IsActive { get; set; } = false;
    }
}
