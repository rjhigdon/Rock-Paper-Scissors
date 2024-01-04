using RoPaSc;
using System.Runtime.CompilerServices;

bool continueGame = true;

while (continueGame)
{
Console.WriteLine("Let's Play a game of Rock, Paper, Scissors. \nTo Make your move, simply type one of those three options");
String myChoice = Console.ReadLine();


string compChoice = CompChoice.PickChoice();


Results results = new Results();
results.Result(myChoice, compChoice);

Console.WriteLine("Play Again? yes/no");
string continueRoPaSc = Console.ReadLine();
    continueGame = continueRoPaSc.ToLower().Equals("yes");
}