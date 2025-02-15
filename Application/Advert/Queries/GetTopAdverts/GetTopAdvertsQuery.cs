using Application.Advert.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Advert.Queries.GetTopAdverts
{
    public class GetTopAdvertsQuery : IRequest<ICollection<AdvertDTO>?>
    {
        public int Amount { get; set; }
        public int Offset { get; set; }

        public GetTopAdvertsQuery(int amount, int offset)
        {
            Amount = amount;
            Offset = offset;
        }
    }
}
