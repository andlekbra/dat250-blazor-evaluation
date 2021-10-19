using System;
using System.Collections.Generic;
using System.Text;

namespace dat250_blazor_evaluation.Shared.Models
{
    public class PollTemplate
    {
        public int ID { get; set; }
        public string title { get; set; }
        public string question { get; set; }
        public string redAnswer { get; set; }
        public string greenAnswer { get; set; }
        public VoterProfile creator { get; set; }
        public ICollection<Poll> Polls { get; set; }
    }
}
