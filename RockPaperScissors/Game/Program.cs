using System;
using CPlyr;
using Ref;

namespace RPSGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // P1 input
            String p1Input = "";

            // Call COM
            CPHand cpu = new CPHand();

            // Call referee
            Match ManVSMachine = new Match();
            

            while(!p1Input.Equals("y"))
            {
                // Get P1 input
                Console.WriteLine("Rock, Paper, Scissors!");
                p1Input = Console.ReadLine();

                // Get COM input
                String cpuInput = cpu.ThrowRandomHand();

                // Start Match
                ManVSMachine.StartMatch(p1Input, cpuInput);

                Console.WriteLine("Quit match? y/n");
                p1Input = Console.ReadLine();
                p1Input = p1Input.ToLower();

            }

            // Display results 
            ManVSMachine.AnnounceResults();
                        
        }

    }
    
}
