using Microsoft.AspNetCore.Mvc;
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
        public bool? CvMandatory { get; set; }
        public string? CompanyName { get; set; }
        public string? PositionName { get; set; }
        public string? SeniorityLevelName { get; set; }
        public decimal? MinSalary { get; set; }
        public decimal? MaxSalary { get; set; }
        public string? Location { get; set; }
    }
}
 