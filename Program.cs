namespace Topic_Two___Number_and_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, passwordUseless;
            int yearOfBirth;
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
            string year = DateTime.Parse(DateTime.Now.ToString()).Year.ToString();
            Convert.ToInt32(year);
            Console.WriteLine(yearOfBirth + year);


        }
    }
}