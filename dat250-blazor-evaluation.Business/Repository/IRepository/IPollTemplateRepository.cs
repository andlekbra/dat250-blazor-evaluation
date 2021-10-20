using dat250_blazor_evaluation.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dat250_blazor_evaluation.Business.Repository
{
    public interface IPollTemplateRepository
    {
        public Task<PollTemplateDTO> CreatePollTemplate(PollTemplateDTO pollTemplate);

        public Task<PollTemplateDTO> GetPollTemplate(int id);
        public Task<IEnumerable<PollTemplateDTO>> GetAllPollTemplates();
    }
}
