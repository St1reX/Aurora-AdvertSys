using Application.AdvertDependent.WorkModel.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AdvertDependent.WorkModel.Queries.GetAllWorkModels
{
    public class GetAllWorkModelsQuery : IRequest<IEnumerable<WorkModelDTO>>
    {
    }
}
