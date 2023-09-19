namespace Topic_Two___Number_and_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, passwordUseless, friendName;
            int yearOfBirth, year, theFirstNumber, theSecondNumber, theThirdNumber;
            double km1, km2, km3;
            Console.WriteLine("Hello, to continue please enter your name.");
            name = Console.ReadLine();
            Console.WriteLine($"Thanks {name} please wait while we get your account setup this may take a moment....");
            Thread.Sleep(7000);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Thanks for waiting {name} please create a password below.");
            passwordUseless = Console.ReadLine();
            Thread.Sleep(1000); 
            Console.WriteLine($"Thanks, now, please type how old you are");
            yearOfBirth = Convert.ToInt32(Console.ReadLine());
            Thread.Sleep(1000);
            Console.WriteLine($"Thanks {name} ");
            year = DateTime.Now.Year;
    
            Console.WriteLine($"You were born in {year - yearOfBirth}");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Now, please type a number below.");
            theFirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine($"Great {name}! Now pick a second number");
            theSecondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine($"Great {name}! Now pick a third number");
            theThirdNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine($"Great {name}! Now I will take all three numbers and add them together!!");
            Console.WriteLine($"{ theFirstNumber + theSecondNumber + theThirdNumber} is all three numbers added together.");
            Thread.Sleep(3000);
            Console.WriteLine("");
            Console.WriteLine("Imagine were going on a trip three times with your friend please make a name for your friend!");
            friendName = Console.ReadLine();
            Console.WriteLine($"Thanks! {friendName} is a great name for a friend!");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.WriteLine($"Please input the amount of kilometers in your first trip with {friendName}");
            km1 = Convert.ToDouble(Console.ReadLine());
            Thread.Sleep(500);
            Console.WriteLine($"Thanks {name}!");
            Console.WriteLine("");
            Console.WriteLine("Now please input the amount of kilometers in your second trip.");
            km2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Perfect {name}!!");
            Thread.Sleep(500);
            Console.WriteLine();    
            Console.WriteLine($"Alright {name}, please input your final trip!");
            km3 = Convert.ToDouble(Console.ReadLine());
            Thread.Sleep(500);
            Console.WriteLine();
            Console.WriteLine("Loading the response...");
            Thread.Sleep(500);
            Console.WriteLine("Loading the response...");
            Thread.Sleep(500);
            Console.WriteLine("Loading the response...");
            Thread.Sleep(500);
            Console.WriteLine("Loading the response...");
            Thread.Sleep(500);
            Console.WriteLine("Loading the response...");
            Thread.Sleep(500);
            Console.WriteLine("Loading the response...");
            Thread.Sleep(500);
            Console.WriteLine("Loading the response...");
            Thread.Sleep(500);
            Console.WriteLine("Loading the response...");
            Thread.Sleep(2000);
            Console.WriteLine($"Thanks for your patience {name} we've created a story for you! Sit back and enjoy!");
            Console.WriteLine("");
            Console.WriteLine("");
            Thread.Sleep(3000);
            Console.WriteLine($"One day {name} and {friendName} were enjoying a nice day. 'Hey {friendName} you know what I want?' said {name} 'What?' said {friendName}.");
            Console.WriteLine($"'I want to go on a road trip!' said {name} 'hmm that could be fun!' {friendName} said with enthusiasm 'Yeah but how about three trips?!'");
            Console.WriteLine($"{name} said. They both agreed apon three road trips in one day. At the end they racked up quite a bit of kilometers on their little Skoda Fabia.");
            Console.WriteLine($"On the first trip they drove {km1}km, then on their second trip they drove {km2}km, and finally on there final trip they drove {km3}km!");
            Console.WriteLine("");
            Console.WriteLine("To continue, click 'ENTER'");
            Console.ReadLine();
            Console.WriteLine("I would like to tell you the average kilometers of all three of your trips!");
            km1 = Math.Round(km1, 2);
            km2 = Math.Round(km2, 2);
            km3 = Math.Round(km3, 2);
            km1 = km1 + km2 + km3 / 3;
            km1 = Math.Round(km1, 2);
            Console.WriteLine($"Your trip average is {km1}.");

        }
    }
}