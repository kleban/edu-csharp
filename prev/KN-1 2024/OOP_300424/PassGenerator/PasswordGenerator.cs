using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassGenerator
{
    public class PasswordGenerator
    {
        /*private int lenght;
        private bool useLowercase;
        private bool useUppercase;
        private bool useNumbers;
        private bool useSymbols;*/

                    /*public PasswordGenerator()
        {
this.lenght = lenght;
            this.useLowercase = useLowercase;
            this.useUppercase = useUppercase;
            this.useNumbers = useNumbers;
            this.useSymbols = useSymbols;
        }*/

        public string Generate(int lenght,
            bool useLowercase,
            bool useUppercase,
            bool useNumbers,
            bool useSymbols)
        {
            StringBuilder password = new StringBuilder();

            string lowercaseChars = "abcdefghijklmnopqrstuvwxyzабвгґдеєжзиіїйклмнопрстуфхцчшщьюя";
            string uppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZАБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ";
            string NumbersChars = "0123456789";
            string specialChars = @"!?@#*$%^&/\|(){}[]<>";

            Random random = new Random();
            while (password.Length < lenght)
            {
                if (useLowercase)
                    password.Append(lowercaseChars[random.Next(lowercaseChars.Length)]);
                if (useUppercase)
                    password.Append(uppercaseChars[random.Next(uppercaseChars.Length)]);
                if (useNumbers)
                    password.Append(NumbersChars[random.Next(NumbersChars.Length)]);
                if (useSymbols)
                    password.Append(specialChars[random.Next(specialChars.Length)]);
            }

            for (int i = 0; i < password.Length; i++)
            {
                int randomIndex = random.Next(password.Length);
                char temp = password[i];
                password[i] = password[randomIndex];
                password[randomIndex] = temp;
            }
            return password.ToString();
        }

       /*public int PasswordEvaluation()
        {
            int complexity = 0;

            if (Lenght >= 8 && Lenght <= 13)
                complexity += 1;
            else if (Lenght >= 14 && Lenght <= 19)
                complexity += 2;
            else if (Lenght >= 20 && Lenght <= 30)
                complexity += 3;

            if (UseLowercase)
                complexity += 2;
            if (UseUppercase)
                complexity += 2;
            if (UseNumbers)
                complexity += 1;
            if (UseSymbols)
                complexity += 2;

            return complexity;
        }*/

        /*public static int PasswordLenght()
        {
            Console.Write("Введіть довжину пароля від 5 до 30\n\tВаш вибір: ");
            int lenght;

            while (!int.TryParse(Console.ReadLine(), out lenght) || lenght < 5 || lenght > 30)
            {
                Console.Write("Ви ввели не правильне число, спробуйте ще раз: ");
            }
            return lenght;
        }*/

        /*public static bool PasswordLowercase()
        {
            Console.Write("\nНаявність малих букв\n1 - Так;   2 - Ні\n\tВаш вибір: ");
            int choice;

            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 2)
            {
                Console.Write("Ви ввели не коректне число, спробуйте ще раз: ");
            }

            if (choice == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/

        /*public static bool PasswordUppercase()
        {
            Console.Write("\nНаявність великих букв\n1 - Так;   2 - Ні\n\tВаш вибір: ");
            int choice;

            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 2)
            {
                Console.Write("Ви ввели не коректне число, спробуйте ще раз: ");
            }

            if (choice == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/

        /*public static bool PasswordNumbers()
        {
            Console.Write("\nНаявність цифр\n1 - Так;   2 - Ні\n\tВаш вибір: ");
            int choice;

            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 2)
            {
                Console.Write("Ви ввели не коректне число, спробуйте ще раз: ");
            }

            if (choice == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/

        /*public static bool PasswordSymbols()
        {
            Console.Write("\nНаявність cимволів\n1 - Так;   2 - Ні\n\tВаш вибір: ");
            int choice;

            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 2)
            {
                Console.Write("Ви ввели не коректне число, спробуйте ще раз: ");
            }

            if (choice == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/
    }
}
