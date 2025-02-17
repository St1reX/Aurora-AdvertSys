using Application.Advert.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Advert.Queries.GetFilteredAdverts
{
    public class GetFilteredAdvertsQuery : AdvertFilterDTO, IRequest<ICollection<AdvertDTO?>>
    {
    }
}
