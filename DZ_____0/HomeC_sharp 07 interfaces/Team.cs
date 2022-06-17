using System;
using System.Collections.Generic;
using System.Text;

namespace dz_int
{
    class Team : IWorker
    {
        String NameTeam { get; }

        string IWorker.Name => NameTeam;
        public TeamLeader leader;
        public List<Worker> workers;
        public Team(TeamLeader leader)
        {
            this.leader = leader;
            workers = new List<Worker> { new Worker("Nazar"), new Worker("Vasya"), new Worker("Vitaly") };
        }
    }
}
