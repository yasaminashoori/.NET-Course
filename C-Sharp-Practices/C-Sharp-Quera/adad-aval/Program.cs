namespace adad_aval;
class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Enter two numbers:");
       var firstNumber = int.Parse(Console.ReadLine());
       var secondNumber = int.Parse(Console.ReadLine());
       for (int i = firstNumber; i <= secondNumber; i++)
       {
            var adadAval = i;
            if (firstNumber % 1 == 0 && secondNumber % 1 == 0 && i % 1 == 0 && firstNumber % firstNumber == 0  && secondNumber % secondNumber == 0 && i % i == 0)

            {
                Console.WriteLine("there isn't any prime numbr");
            }
            else
            {
                Console.WriteLine("The result: ");
                Console.WriteLine($"{firstNumber} {i} {secondNumber}");
            }
       }
    }
}
