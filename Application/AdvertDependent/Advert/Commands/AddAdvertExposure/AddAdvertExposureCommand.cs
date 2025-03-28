using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AdvertDependent.Advert.Commands.AddAdvertExposure
{
    public class AddAdvertExposureCommand : IRequest
    {
        public int AdvertID { get; set; }
    }
}
