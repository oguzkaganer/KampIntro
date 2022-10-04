namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 20;
            int number2 = 100;
            // "ref" yerine "out" kullanılabilir.
            // "ref" kullanacaksak number1 e öncesinde bir ddeğer atanması gerekiyor.
            // "out" kullanılacaksa öncesinde bir değer atamamıza gerek yok.
            var result2 = Add3(ref number1, number2);
            Console.WriteLine(result2);

            //"ref" veya "out" kullanılırsa burada number1 30 olur. 
            //Kullanılmazsa 20 olur.

            Console.WriteLine(number1);

            Console.WriteLine(Add4(1,2,3,4,5,6));
            Console.ReadLine();

            static int Add3(ref int number1, int number2)
            {
                number1 = 30;
                return number1+ number2;
            }

            static int Add4(params int[] numbers)
            {
                return numbers.Sum();
            }
        }
    }
}