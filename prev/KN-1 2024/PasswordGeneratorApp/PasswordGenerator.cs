using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGeneratorApp
{
    internal class PasswordGenerator
    {
        public static string GeneratePassword(int length, bool useLowercase, bool useUppercase, bool useNumbers, bool useSpecialChars)
        {
            Random random = new Random();

            const string lowercaseChars = "abcdefghijklmnopqrstuvwxyz";
            const string uppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string numberChars = "0123456789";
            const string specialChars = "!@#$%^&*(){}[]";

            StringBuilder passwordBuilder = new StringBuilder();

            string chars = string.Empty;
            if (useLowercase) chars += lowercaseChars;
            if (useUppercase) chars += uppercaseChars;
            if (useNumbers) chars += numberChars;
            if (useSpecialChars) chars += specialChars;

            for (int i = 0; i < length; i++)            
                passwordBuilder.Append(chars[random.Next(chars.Length)]);

            return passwordBuilder.ToString();
        }

        public static (int, string) EvaluatePasswordStrength(string password)
        {
            int score = 0;
            if (password.Length >= 12) score += 2;
            else if (password.Length >= 8) score++;
            
            if (password.Any(char.IsLower) && password.Any(char.IsUpper)) 
                score+=4;
            else if(password.Any(char.IsLower) || password.Any(char.IsUpper)) score+=2;

            if (password.Any(char.IsDigit)) score++;
            if (password.Any(char.IsLetterOrDigit) && password.Any(c => !char.IsLetterOrDigit(c))) score += 3;

            // simple - 4, medium > 4 & <=7, strong > 7
            string score_text = "simple";

            if (score > 7) score_text = "strong";
            else if (score <= 7 && score > 4) score_text = "medium";

            return (score, score_text);
        }

    }
}

