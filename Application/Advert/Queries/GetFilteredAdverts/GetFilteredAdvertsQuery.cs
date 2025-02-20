using Application.Advert.DTOs;
using Core.Helpers;
using MediatR;

namespace Application.Advert.Queries.GetFilteredAdverts
{
    public class GetFilteredAdvertsQuery : AdvertFilter, IRequest<ICollection<AdvertDTO>?>
    {
    }
}
