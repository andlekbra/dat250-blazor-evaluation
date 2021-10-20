using AutoMapper;
using dat250_blazor_evaluation.DataAccess.Data;
using dat250_blazor_evaluation.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace dat250_blazor_evaluation.Business.Repository
{
    public class PollTemplateRepository : IPollTemplateRepository

    {

        private readonly VoteAppDbContext _db;
        private readonly IMapper _mapper;
        public PollTemplateRepository(VoteAppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<PollTemplateDTO> CreatePollTemplate(PollTemplateDTO pollTemplateDTO)
        {
            PollTemplate pollTemplate = _mapper.Map<PollTemplateDTO, PollTemplate>(pollTemplateDTO);
            var addedPollTemplate = await _db.AddAsync(pollTemplate);
            await _db.SaveChangesAsync();
            return _mapper.Map<PollTemplate,PollTemplateDTO>(addedPollTemplate.Entity);
        }

        public async Task<IEnumerable<PollTemplateDTO>> GetAllPollTemplates()
        {
            try
            {
                IEnumerable<PollTemplateDTO> pollTemplateDTOs = _mapper.Map<IEnumerable<PollTemplate>, IEnumerable< PollTemplateDTO >> (_db.PollTemplates);
                return pollTemplateDTOs;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<PollTemplateDTO> GetPollTemplate(int pollTemplateid)
        {
            try
            {
                PollTemplateDTO pollTemplateDTO = _mapper.Map<PollTemplate, PollTemplateDTO>(
                    await _db.PollTemplates.FirstOrDefaultAsync(x => x.Id == pollTemplateid));
                return pollTemplateDTO;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
