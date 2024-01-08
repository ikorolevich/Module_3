using System.Xml.Linq;

namespace Solution_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string myName;
            byte myAge;

            Console.WriteLine("Enter your name");
            myName = Console.ReadLine();
            Console.WriteLine("Enter your age");
            myAge = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Your name is {0} and your age is {1}",myName, myAge);
            Console.WriteLine("What is your favorite day of week ?");
            byte myDay = Convert.ToByte(Console.ReadLine());
            object day = (DayOfWeek)myDay;

            Console.WriteLine("Your favorite day is {0}",day);



            //byte myAge = Convert.ToByte(Console.ReadLine());
            //byte myAge = (byte)int.Parse(Console.ReadLine());
            object dateTime = DateTime.Now;
            Console.WriteLine(DateTime.Now);

            int nbr = Convert.ToInt16(DayOfWeek.Monday);
            Console.WriteLine(DayOfWeek.Wednesday);
            Console.WriteLine(Convert.ToByte(DayOfWeek.Wednesday));
            



            //Console.WriteLine(result);
            //return;

            //Console.WriteLine("IntMin " + int.MinValue);
            //Console.WriteLine("IntMax " + int.MaxValue);

            //Console.WriteLine(myName);
            //Console.WriteLine($"Меня зовут   {myName}");
            //string name = "Jane";
            //byte age = 43;
            //string favcolor = "black";

            //Console.WriteLine("{0}\n{1}\n{2}",name, age, favcolor);
            //return;

            //Console.WriteLine("Мой возраст {0}", age);

            //Console.WriteLine("\tПривет,\n мир");
            //Console.WriteLine("\tМне 27 лет");
            //Console.WriteLine("\tMy name is \n Jane");
            //Console.WriteLine("\u0023");

            //// Console.ReadKey();

            //DaysOfWeek MyFavoriteDay = DaysOfWeek.Friday;
            //Console.WriteLine(MyFavoriteDay);

            //Console.WriteLine(DayOfWeek.Monday);
            //Console.WriteLine(Semaphore.Green);
          
        }
        
    }

    enum DaysOfWeek : byte
    {
        Tuesday,
        Monday,
        Wednesday,
        Friday
    }

    enum Semaphore : int
    {
        Red = 100,
        Yellow = 200,
        Green = 300
    }
}
