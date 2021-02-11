using System;
using System.Collections;

namespace Ref
{
    public class Match
    {
        static int P1Wins = 0;
        static int COMWins = 0;
        // Valid Choices
        enum ValidChoices
        {
            Rock,
            Paper,
            Scissors
        }
        
        // Start Match
        public void StartMatch(String P1Choice, String COMChoice)
        {
            if(P1Choice.Equals(ValidChoices.Rock.ToString()) || P1Choice.Equals(ValidChoices.Paper.ToString()) || P1Choice.Equals(ValidChoices.Scissors.ToString()))
            {
                //Console.WriteLine("You can play");
                EvaluateMatch(P1Choice, COMChoice);

            }
            else 
            {
                Console.WriteLine("Rock, Paper, or Scissors only. Try again.");
            }
        }
        // Evaluate Match 
        public void EvaluateMatch(String P1Choice, String COMChoice)
        {
            // P1 Wins
            if (P1Choice.Equals("Rock") && COMChoice.Equals("Scissors"))
            {
                Console.WriteLine("P1 Wins");
                P1Wins+= 1;
            }
            else if (P1Choice.Equals("Paper") && COMChoice.Equals("Rock"))
            {
                Console.WriteLine("P1 Wins");
                P1Wins+= 1;
            }
            else if (P1Choice.Equals("Scissors") && COMChoice.Equals("Paper"))
            {
                Console.WriteLine("P1 Wins");
                P1Wins+= 1;
            }
            
            //COM Wins
            else if (COMChoice.Equals("Rock") && P1Choice.Equals("Scissors"))
            {
                Console.WriteLine("COM Wins");
                COMWins+= 1;
            }
            else if (COMChoice.Equals("Paper") && P1Choice.Equals("Rock"))
            {
                Console.WriteLine("COM Wins");
                COMWins+= 1;
            } 
            else if (COMChoice.Equals("Scissors") && P1Choice.Equals("Paper"))
            {
                Console.WriteLine("COM Wins");
                COMWins+= 1;
            }
            
            //Draw
            else 
            {
                Console.WriteLine("Draw");
            }
        }
        
        // Announce Match results
        public void AnnounceResults()
        {
            Console.WriteLine("P1 Wins: " + P1Wins + "\t COM Wins: " + COMWins);
        }

    }
}
