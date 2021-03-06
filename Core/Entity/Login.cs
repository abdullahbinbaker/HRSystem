﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Entity
{
    public class Login 
    {
        public Login()
        {
        }

        public Login(  int employeeId, string emailAddress, string password)
        {
           
            EmailAddress = emailAddress;
            EmployeeId = employeeId;
            Password = password;
        }

        /// <summary>
        /// EmployeeId
        /// </summary>
        [Key]
        [Required]
        public int EmployeeId { get; set; }

        /// <summary>
        /// Employee Email Address
        /// </summary>
        public string EmailAddress { get; set; }
       
        /// <summary>
        /// employee login password
        /// </summary>
        public string Password { get; set; }

    }
}
