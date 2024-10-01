namespace Topic___5_Programming_Assignment___mini_quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secAns, thirdAns, fourthAns, coke, pepsi, both, nither;
            coke = "coke";
            pepsi = "pepsi";
            nither = "nither";
            both = "both";
            int firstAns;
            int score;
            score = 0;
            Console.WriteLine("Welcome to my quiz");
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("you will be answering 4 questions");
            Console.WriteLine("Try to get them right");
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("For your FIRST question");
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.WriteLine("whats 9 + 10?");
            int.TryParse(Console.ReadLine(), out firstAns);
            if (firstAns == 21)
            {
                Console.WriteLine("u stupid");
            }
            else if (firstAns == 19)
            {
                Console.WriteLine("Correct");
                ++score;
            }
            else
            {
                Console.WriteLine("Wrong");
            }
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("For your second question");
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.WriteLine("what do you get after curdling milk?");
            Console.WriteLine();
            secAns = Console.ReadLine().ToLower();
            if (secAns == "cheese")
            {
                Console.WriteLine("indee dee do");
                ++score;
            }
            else
            {
                Console.WriteLine("Wrong");
            }
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("For your third question");
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.WriteLine("what is the fourth fundamental state of matter?");
            Console.WriteLine();
            Console.WriteLine("Gas");
            Console.WriteLine("Plasma");
            Console.WriteLine("Solid");
            Console.WriteLine("Liquid");
            Console.WriteLine();
            thirdAns = Console.ReadLine().ToLower();
            if (thirdAns == "plasma")
            {
                Console.WriteLine("Thats right");
                ++score;
            }
            else if (thirdAns == "gas")
            {
                Console.WriteLine("What, did you just FART out an answer?");
            }
            else if (thirdAns == "Liquid")
            {
                Console.WriteLine("I think you SPILT your iq on the floor");
            }
            else if (thirdAns == "solid")
            {
                Console.WriteLine("it's HARD to belive you thought that was the right answer");
            }
            else
            {
                Console.WriteLine("Wrong");
            }
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("And for the final question");
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.WriteLine("Coke or Pepsi?");
            Console.WriteLine();
            Console.WriteLine("Coke");
            Console.WriteLine("Pepsi");
            Console.WriteLine("nither");
            Console.WriteLine("both");
            Console.WriteLine();
            fourthAns = Console.ReadLine().ToLower();
            if (fourthAns == coke)
            {
                Console.WriteLine("I respet your answer");
                ++score;
            }
            else if (fourthAns == pepsi)
            {
                Console.WriteLine("ehhhhhhhhh no");
            }
            else if (fourthAns == nither)
            {
                Console.WriteLine("Come on really? you have to like at least 1");
            }
            else if (fourthAns == both)
            {
                Console.WriteLine("No, you cant have both");
            }
            else
            {
                Console.WriteLine("Wrong");
            }
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Well you did it...");
            Console.WriteLine("lets see your score");
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("you got " + score + "/4");
            Console.WriteLine();
            if (score == 0)
            {
                Console.WriteLine("how... HOW! HOW DID YOU GET NONE OF THE ANSWERS RIGHT!?");
            }
            else if (score == 1)
            {
                Console.WriteLine("Did you just guess or something?");
            }
            else if (score == 2)
            {
                Console.WriteLine("i guess 50% is still a pass... Congraduations?");
            }
            else if (score == 3)
            {
                Console.WriteLine("you did pretty good");
            }
            else if (score == 4) 
            {
                Console.WriteLine("you got'em all right! Hooray!!");
            }

        }
    }
}
