using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace StateMgtMVC.Models
{
    public class Cust
    {
        [Required(ErrorMessage ="Custid required"]
        public int Custid { get; set; }
        [MaxLength(20,ErrorMessage ="Name cannot be greater than 20 chars")]
        public string Custname { get; set; }
        
        public string City { get; set; }
        [EmailAddress(ErrorMessage ="Enter valid emaild id ")]
        public string CustEmail { get; set; }
    }
}