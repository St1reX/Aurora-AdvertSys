﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Advert.DTOs
{
    public class AdvertFilterDTO
    {

        public int? Amount { get; set; }
        public int? Offset { get; set; }
        public bool? CVMandatory { get; set; }
        public int? CompanyID { get; set; }
        public int? PositionID { get; set; }
        public int? SeniorityLevelID { get; set; }
        public decimal? MinSalary { get; set; }
        public decimal? MaxSalary { get; set; }
        public string? Location { get; set; }
    }
}
 