﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.AdvertDependent
{
    public class ContractType
    {
        public int ContractTypeID { get; set; }
        public string ContractTypeName { get; set; } = default!;

        public ICollection<Advert> Adverts { get; set; } = new List<Advert>();
    }
}
