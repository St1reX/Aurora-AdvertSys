﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ContractType.DTOs
{
    public class ContractTypeDTO
    {
        public int ContractTypeID { get; set; }
        public string ContractTypeName { get; set; } = default!;
    }
}
