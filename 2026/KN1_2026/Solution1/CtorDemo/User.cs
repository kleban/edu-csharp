using System;
using System.Collections.Generic;
using System.Text;

namespace CtorDemo
{
    public class User 
    {
        private string name;
        private string email;
        private int age;

        /// <summary>
        /// Повний конструктор
        /// </summary>
        /// <param name="name">Імя користувача</param>
        /// <param name="email">Email користувача</param>
        /// <param name="age">Вік користувача</param>
        public User(string name, string email, int age)
        {
            this.age = age;
            this.email = email;
            this.name = name;
            Console.WriteLine("Ctor 3");
        }

        /// <summary>
        /// Конструктор з 1 параметром
        /// </summary>
        /// <param name="name">Імя користувача</param>
        public User(string name) 
            : this(name, "real_email@gmail.com", 16)
        {
            Console.WriteLine("Ctor 2");
        }

        /// <summary>
        /// Конструктор за замовчуванням
        /// </summary>
        public User() 
            : this("empty")
        {
            Console.WriteLine("Ctor 1");
        }

        public override string ToString()
        {
            return $"{name} ({email}) -> {age} y.o.";
        }
    }
}
