using Application.AdvertDependent.Advert.DTOs;
using Core.Helpers;
using MediatR;

namespace Application.AdvertDependent.Advert.Queries.GetFilteredAdverts
{
    public class GetFilteredAdvertsQuery : AdvertFilter, IRequest<ICollection<AdvertDTO>?>
    {
    }
}
