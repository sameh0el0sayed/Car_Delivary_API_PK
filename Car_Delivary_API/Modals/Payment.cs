namespace Car_Delivary_API.Modals
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Payment
    {
        [Key]
        [Required] 
        public string PaymentID { get; set; } = Guid.NewGuid().ToString();
        [Required]
        public string TripID { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.Now;
        [Required] public string PaymentMethod { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalAmount { get; set; } = 0;
        [Column(TypeName = "decimal(18,2)")]
        public decimal Taxes { get; set; }
        [Required] public string TransactionID { get; set; }
        public int PaymentStatus { get; set; }

        public bool IsActive { get; set; } = false;

    }
}
