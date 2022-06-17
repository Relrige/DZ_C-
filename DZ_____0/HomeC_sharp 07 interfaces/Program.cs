using System;

namespace dz_int
{
    class Program
    {
        static void Main(string[] args)
        {
            TeamLeader leader = new TeamLeader("Vitaly");
            Team team = new Team(leader);
            House house = new House();
            Worker worker = new Worker("Maksim");
            team.workers.Add(worker);
            Console.WriteLine(worker);
            foreach (var item in team.workers)
            {
                Console.WriteLine(item);
            }
            worker.BuildHouse(house, leader);
            foreach (var item in leader.message)
            {
                Console.WriteLine(item);
            }
            house.RenderHouse();

        }
    }
}
