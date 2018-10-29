using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModelFund.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please Enter Your Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "PleaseEnter Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter Phone Number")]
        public string Phone { get; set; }

        public bool? WillAttend { get; set; }
    }
}