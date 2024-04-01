using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Car_Delivary_API.Modals
{
    public class Vehicle
    {
        [Key]
        [MaxLength(50)]
        public string VehicleID { get; set; } = Guid.NewGuid().ToString();
        [Required]
        [MaxLength(50)]
        public string DriverID { get; set; } 
        [Required]
        public int Year { get; set; }
        [MaxLength(20)]
        public string Make { get; set; }    = string.Empty;
        [MaxLength(20)]
        public string Model { get; set; } = string.Empty;
        [MaxLength(20)]
        public string LicensePlateNo { get; set; } = string.Empty;
        [MaxLength(20)]
        public string CarType { get; set; } = string.Empty;
        public bool IsActive { get; set; }=false;

 
    }
}
