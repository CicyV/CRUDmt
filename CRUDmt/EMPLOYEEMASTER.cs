//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRUDmt
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;
    
    public partial class EMPLOYEEMASTER
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please enter Employee name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter Description.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please enter Salary")]
        public string Salary { get; set; }
    }
}
