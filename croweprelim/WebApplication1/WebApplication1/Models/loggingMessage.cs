﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class loggingMessage
    {
        [Required]
        public string msg { get; set; }

        public string sender { get; set; }
    }
}