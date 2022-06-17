using System;
using System.Collections.Generic;
using System.Text;

namespace dz_int
{

    interface IBuilder
    {
        void BuildHouse(House house, TeamLeader leader);
    }

    class Worker : IWorker, IBuilder
    {
        private String Name { get; set; }
        String IWorker.Name => Name;
        public readonly uint ID;
        public static uint Counter;
        public Worker(String name)
        {
            this.Name = name;
            ID = ++Counter;
        }

        public void BuildHouse(House house, TeamLeader leader)
        {
            if (house.basement == null)
            {
                Basement basement = new Basement();
                basement.Work(house);
                leader.message.Add($"Worker {Name} created basement...");
            }
            if (house.door == null)
            {
                Door door = new Door(DoorType.Iron);
                door.Work(house);
                leader.message.Add($"Worker {Name} created door...");

            }
            if (house.walls == null)
            {
                house.walls = new List<Walls>();
                Walls walls_ = new Walls();
                walls_.Work(house);
                leader.message.Add($"Worker {Name} created walls...");

            }
            if (house.window == null)
            {
                house.window = new List<Window>();
                Window window_ = new Window(TypeWindow.Shape);
                window_.Work(house);
                leader.message.Add($"Worker {Name} created window...");
            }
            if (house.roof == null)
            {
                Roof roof = new Roof(TypeRoof.Stone);
                roof.Work(house);
                leader.message.Add($"Worker {Name} created roof...");
            }
        }
        public override string ToString()
        {
            return $"ID worker : {ID}\n" +
                $"Name : {Name}";
        }
    }
}
