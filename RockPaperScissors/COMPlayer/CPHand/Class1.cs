using System;

namespace CPlyr
{
    public class CPHand
    {
        // Hand
        enum Hand
        {
            Rock, 
            Paper, 
            Scissors
        } 

        // Throw Random Hand
        public String ThrowRandomHand()
        {
            Random r = new Random();
            var v = Enum.GetValues(typeof(Hand));
            var result = v.GetValue(r.Next(v.Length));
            return result.ToString();
        }
    }
}
