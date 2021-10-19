using System.Collections.Generic;

namespace dat250_blazor_evaluation.Shared.Models
{
    public class VoterProfile
    
    {
        public int ID { get; set; }
        public string userName { get; set; }
        public string email { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string password { get; set; }
        public ICollection<PollTemplate> PollTemplates { get; set; }
    }
}