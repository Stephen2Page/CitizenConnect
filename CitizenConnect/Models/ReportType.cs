﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CitizenConnect.Models
{
    public class ReportType
    {
        [Key]
        public int ReportTypeID { get; set; }
        [Display(Name ="Type of Report")]
        public string ReportTypeName { get; set; }
    }
}