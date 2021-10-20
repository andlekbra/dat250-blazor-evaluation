using AutoMapper;
using dat250_blazor_evaluation.DataAccess.Data;
using dat250_blazor_evaluation.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dat250_blazor_evaluation.Business.Mapper
{
    class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<PollTemplateDTO, PollTemplate>();
            CreateMap<PollTemplate, PollTemplateDTO>();
        }
    }
}
