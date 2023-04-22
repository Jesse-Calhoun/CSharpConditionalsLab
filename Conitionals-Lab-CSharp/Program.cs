namespace Conitionals_Lab_CSharp;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, test!");

        int drivingAge = 16;
        Console.WriteLine("How old are you?");
        int usersAge = Convert.ToInt32(Console.ReadLine());

        if (usersAge >= drivingAge)
        {
            Console.WriteLine("You are legally able to drive.");
        }
        else
        {
            Console.WriteLine("You are not old enough to drive yet.");
        }
    }
}

