using System;

namespace lect14.task2
{
    class Program
    {
        static void Main(string[] args)
        {
            NeighborRepository neighborsRepository = new NeighborRepository();
            neighborsRepository.AddNeighbor("Ivanov Petr", 5, 1230055);
            neighborsRepository.AddNeighbor("Smirnov Mihail", 9, 3236543);
            neighborsRepository.AddNeighbor("Petrov Viktor", 3, 1452236);
            neighborsRepository.AddNeighbor("Abdurahman Ramzan", 11, 6664466);
            Console.Write("Tell the apartment number: ");
            int number;
            bool success = Int32.TryParse(Console.ReadLine(), out number);
            if (success)
            {
                Neighbor neighbor = neighborsRepository.GetNeighbor(number);
                neighborsRepository.PrintInfoNeighbor(neighbor);
            }
        }
    }
}