using Application.WorkModel.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.WorkModel.Queries.GetAllWorkModels
{
    public class GetAllWorkModelsQuery : IRequest<IEnumerable<WorkModelDTO>>
    {
    }
}
