//Name:             Ahmed Butt
//Student ID:       100770449
//Project:          NETD3202 Lab 5
//Last Modified:    Dec 3, 2020

//This model is used for ForgotPassword. It assists in finding the email whether it exists in the database or not.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NETD3202_Lab5_V2.Models
{
    public class ForgotPasswordModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
