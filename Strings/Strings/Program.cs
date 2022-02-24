
namespace Strings
{
    class Program {
        static void Main(string[] args)
        {
            /*
            string s = "1234";

            int i = int.Parse(s);

            int j = Convert.ToInt32(s);

            Console.WriteLine(j);
            */

            var fullName = "Luis Medina ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);

           var names = fullName.Split(' ');
            Console.WriteLine("First Name: " + names[0]);
            Console.WriteLine("Last Name: " + names[1]);

            Console.WriteLine(fullName.Replace("Luis", "Luisfegh"));

            if (String.IsNullOrEmpty(null))
            {
                Console.WriteLine("Invalid");
            }
            /*
            if (String.IsNullOrEmpty(" ".Trim()))
            {
                Console.WriteLine("Invalid");

            Microsoft creates a new method called: IsNullOrWhiteSpace.
            }
            */ 
            if (String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invalid");
            }

        }
     }
}
