using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dat250_blazor_evaluation.DataAccess.Data
{
    public class VoteAppDbContext : DbContext
    {
        public VoteAppDbContext(DbContextOptions<VoteAppDbContext> options) : base(options)
        { }
       
        public DbSet<VoterProfile> VoterProfiles { get; set; }
       public DbSet<PollTemplate> PollTemplates { get; set; }
       public DbSet<Poll> Polls { get; set; }
       public DbSet<IoTDevice> IoTDevices { get; set; }
       public DbSet<VoteCount> VoteCounts { get; set; }
    }
}
