using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AdvertDependent.Advert.Events.AdvertViewed
{
    public class AdvertViewedEvent : INotification
    {
        public int AdvertId { get; set; }

    }
}
