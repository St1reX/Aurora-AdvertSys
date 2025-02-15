using Application.Advert.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Advert.Queries.GetAllAdverts
{
    public class GetAllAdvertsQuery : IRequest<ICollection<AdvertDTO>?>
    {
    }
}
