using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoPaSc
{
    internal class CompChoice
    {
        public static string PickChoice()
        {
            Random rnd = new Random();

            int compChoiceNum = rnd.Next(1,4);
            if (compChoiceNum == 1)
            {
                return "rock";
            }
            else if (compChoiceNum == 2)
            {
                return "paper";
            }
            else
            {
                return "scissors";
            }
            
        }
    }
}
