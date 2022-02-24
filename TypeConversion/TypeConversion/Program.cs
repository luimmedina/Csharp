
namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*
                var number = "1234";
                byte b = Convert.ToByte(number);
                Console.WriteLine(b);
                */

                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }

            /*
            byte b = 1;
            int i = b;
            Console.WriteLine(i);
            */

            /*
            int i = 1;
            byte b = i;  no lo compila.
            */

            /*
            int i = 1;
            byte b = (byte)i;
            Console.WriteLine(b);
            */

            /*
            var number = "1234";
            int i = (int)number; no lo compila.
            */

            /*
            var number = "1234";
            int i = Convert.ToInt32(number);
            Console.WriteLine(i);
            */
            

            /*
            var numero = "1234";
            byte b = Convert.ToByte(numero); Surge una excepcion.
            Console.WriteLine(i);
            */

        }
    }
}
