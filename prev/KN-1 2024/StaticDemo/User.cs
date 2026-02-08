using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    public class User
    {
        public static int Count = 0;
        public readonly int UserId;

        public User()
        {
            UserId = new Random().Next(1000, 10000);
            Count++;
        }

        public string Info()
        {
            return $"{UserId}, count {Count}";
        }

        public static void Increase()
        {
            Count++;
        }
    }
}
