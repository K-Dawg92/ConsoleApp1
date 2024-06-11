using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Please enter your age");
        //int age = Convert.ToInt32(Console.ReadLine());
        //if (age >= 21)
        //{
        //    Console.WriteLine("You are signed up to the club. Welcome!");
        //}
        //else
        //{
        //    Console.WriteLine("you must be older than 21, now gerrout of here.");
        //}
        //Console.WriteLine("How many times did Real Madrid win the champions league");
        //int answer = Convert.ToInt32(Console.ReadLine());
        //if (answer == 15) ;
        //else
        //{
        //    Console.WriteLine("Sorry, but the answer is 15");
        //}


        int limit1 = 0;
        int limit2 = 0;
        int value1 = 1;


        //while(!(limit1 <= value1 && value1 <= limit2))
        //    {
        //    Console.WriteLine("Please enter a minimum number");
        //    limit1 = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Please enter a maximum number");
        //    limit2 = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("please enter a number");
        //    value1 = Convert.ToInt32(Console.ReadLine());

        //    if (limit1 <= value1 && value1 <= limit2)
        //    {
        //        Console.WriteLine("WelL done");

        //    }
        //    else
        //    {
        //        Console.WriteLine("that is wrong, try again");
        //    }

        //}

        //Console.ReadLine();

        int Answer1 = 0;
        int Answer2 = 0;
        int entry3 = 1;

        Console.WriteLine("Please enter a minimum number");
        Answer1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter a maximum number");
        Answer2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter any number of your choice");
        entry3 = Convert.ToInt32(Console.ReadLine());
        if (Answer1 <= entry3 && entry3 <= Answer2)
        {
            Console.WriteLine("Well done");
        }
        else
        {
            Console.WriteLine("Try again");
        }
        Console.ReadLine();

    }
}
    