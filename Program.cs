namespace Topic_Two___Number_and_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, passwordUseless, friendName;
            int yearOfBirth, year, theFirstNumber, theSecondNumber, theThirdNumber;
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
            Console.ReadLine();
            Console.WriteLine($"Thanks! {friendName} is a great name for a friend!");
        }
    }
}