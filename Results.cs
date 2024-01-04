using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoPaSc
{
    public class Results
    {
        public void Result(string myChoice, string compChoice)
        {
            if (myChoice.Equals(compChoice))
            {
                Console.WriteLine($"I picked {compChoice}. We Tied");
            }
            else if (myChoice == "Rock" && compChoice == "Paper")
            {
                Console.WriteLine($"I win! I chose {compChoice}");
            }
            else if (myChoice == "Rock" && compChoice == "Scissors")
            {
                Console.WriteLine($"You win! I chose {compChoice}");
            }
            else if (myChoice == "Paper" && compChoice == "Scissors")
            {
                Console.WriteLine($"I win! I chose {compChoice}");
            }
            else if (myChoice == "Paper" && compChoice == "Rock")
            {
                Console.WriteLine($"You win! I chose {compChoice}");
            }
            else if (myChoice == "Scissors" && compChoice == "Rock")
            {
                Console.WriteLine($"I win! I chose {compChoice}");
            }
            else if (myChoice == "Scissors" && compChoice == "Paper")
            {
                Console.WriteLine($"You win! I chose {compChoice}");
            }
        }
    }
}
