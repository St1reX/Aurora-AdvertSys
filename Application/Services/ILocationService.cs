﻿using Application.Advert.DTOs;
using Application.DTOs;
using Core.Entities.UserDependent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface ILocationService
    {
        Task<LocationData> GetCoordinates();
    }
}
