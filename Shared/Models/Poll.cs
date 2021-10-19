using System;
using System.Collections.Generic;

namespace dat250_blazor_evaluation.Shared.Models
{
    public class Poll
    {
        public int ID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime StopTime { get; set; }
        public int JoinCode { get; set; }
        public string name { get; set; }
        public PollTemplate Template { get; set;}
        public VoteCount voteCount { get; set; }
        public ICollection<IoTDevice> IoTDevices { get; set; }
    }
}