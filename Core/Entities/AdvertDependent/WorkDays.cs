﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.AdvertDependent
{
    public class WorkDays
    {
        public int WorkDaysID { get; set; }
        public string WorkDaysName { get; set; } = default!;

        public ICollection<Advert> Adverts { get; set; } = new List<Advert>();
    }
}
