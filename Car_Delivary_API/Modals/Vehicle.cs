using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Car_Delivary_API.Modals
{
    public class Vehicle
    {
        [Key]
        public int CarID { get; set; }
        [Required]
        public int DriverID { get; set; }
        [Required]
        public int Year { get; set; }
        public string Make { get; set; }    = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string LicensePlateNo { get; set; } = string.Empty;  
        public string CarType { get; set; } = string.Empty;
        public bool IsActive { get; set; }=false;

        [ForeignKey("DriverID")]
        public Driver Driver { get; set; }
    }
}
