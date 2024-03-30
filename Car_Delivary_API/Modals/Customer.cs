namespace Car_Delivary_API.Modals
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
    
        public bool IsActive { get; set; }=false;
    }
}
