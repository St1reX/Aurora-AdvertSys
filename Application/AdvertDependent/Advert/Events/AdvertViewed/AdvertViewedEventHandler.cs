using Application.AdvertDependent.Advert.Commands.AddAdvertExposure;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AdvertDependent.Advert.Events.AdvertViewed
{
    public class AdvertViewedEventHandler : INotificationHandler<AdvertViewedEvent>
    {
        private readonly IMediator mediator;

        public AdvertViewedEventHandler(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task Handle(AdvertViewedEvent notification, CancellationToken cancellationToken)
        {
            await mediator.Send(new AddAdvertExposureCommand{AdvertID = notification.AdvertId});
        }
    }
}
