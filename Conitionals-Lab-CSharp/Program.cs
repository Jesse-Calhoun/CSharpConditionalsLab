namespace Conitionals_Lab_CSharp;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, test!");

        //int drivingAge = 16;
        //Console.WriteLine("How old are you?");
        //int usersAge = Convert.ToInt32(Console.ReadLine());

        //if (usersAge >= drivingAge)
        //{
        //    Console.WriteLine("You are legally able to drive.");
        //}
        //else
        //{
        //    Console.WriteLine("You are not old enough to drive yet.");
        //}

        //Random rnd = new Random();
        //int randomNumber = rnd.Next(1, 11);

        //Console.WriteLine(randomNumber);

        //if (randomNumber >= 0 && randomNumber <= 2)
        //{
        //    Console.WriteLine("0 or 1 or 2.");
        //}
        //else if (randomNumber >= 3 && randomNumber <= 5)
        //{
        //    Console.WriteLine("3 or 4 or 5.");
        //}
        //else if (randomNumber >= 6 && randomNumber <= 8)
        //{
        //    Console.WriteLine("6 or 7 or 8.");
        //}
        ////if (randomNumber >= 9 && randomNumber <= 10)
        //else
        //{
        //    Console.WriteLine("9 or 10.");
        //}

        Console.WriteLine("What is your favorite football team?");
        string str = Console.ReadLine();
        while (str.Length >= 1)
        {
            string favoriteTeam = (char.ToUpper(str[0]) + str.Substring(1));


            if (favoriteTeam == "Vikings")
            {
                Console.WriteLine("Loud noises!");
                break;
            }
            else if (favoriteTeam == "Bears")
            {
                Console.WriteLine("Quarterback much?");
                break;
            }
            else if (favoriteTeam == "Lions")
            {
                Console.WriteLine("LOL! They bad!");
                break;
            }
            else if (favoriteTeam == "Packers")
            {
                Console.WriteLine("Best team in the world! Actually, the universe!");
                break;
            }
            else
            {
                Console.WriteLine("Pick different team.");
                str = Console.ReadLine();
            }
        }
    }
}

