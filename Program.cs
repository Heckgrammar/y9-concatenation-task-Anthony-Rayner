namespace ConcatenationTaskAGS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INPUT
            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter second name: ");
            string secondName = Console.ReadLine();
            Console.Write("Enter age: ");
            string age = Console.ReadLine();

            // OUTPUT
            Console.WriteLine("Hello " + firstName + " " + secondName + " you are " + age + " years old");
        }
    }
}
