

namespace ConsoleApp9
{
    internal class Program
    {
        public static void Main(string[] args)
        {

   

            Console.WriteLine("merged to main");
            Console.WriteLine("merged to main");
            Console.WriteLine("merged to main");
            Console.WriteLine("merged to main");

            //added new comment

            var arr = new[] { 1, 2, 3, 4, 4, 5, 6 };
            for(int i = 0;i<arr.Length; i++)
            {
                Console.WriteLine(i);
            }


            Console.ReadKey();
        }
    }
}