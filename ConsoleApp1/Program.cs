
namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //00_getting familiar with datatypes in c#
            var number = 2;
            var count = 10;
            var totalPrice = 20.95f;
            var character = 'M';
            var firstName = "Mahsan";
            var isWorking = false;


            System.Console.WriteLine(number);
            System.Console.WriteLine(count);
            System.Console.WriteLine(totalPrice);
            System.Console.WriteLine(character);
            System.Console.WriteLine(firstName);
            System.Console.WriteLine(isWorking);

            //01_placeholders
            System.Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            System.Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            //02_constant
            const float Pi = 3.14f;
            System.Console.WriteLine(Pi);

            //03_typeConversion

            byte b = 1;
            int i = b;

            System.Console.WriteLine(i);

            var numberToBeConverted = "1234";
            int numberInInt = Convert.ToInt32(numberToBeConverted);
            System.Console.WriteLine(numberInInt);

            //04_handlingException
            try
            {
                var num = "1234";
                byte byteToConvertIn = Convert.ToByte(num);
                System.Console.WriteLine(byteToConvertIn);
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("The number could not be converted to a byte.");

            }


        }   
    }
}
    