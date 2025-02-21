using Application.SeniorityLevel.DTOs;
using Core.Entities.AdvertDependent;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.SeniorityLevel.Queries.GetAllSeniorityLevels
{
    public class GetAllSeniorityLevelsQuery : IRequest<IEnumerable<SeniorityLevelDTO>?>
    {
    }
}
