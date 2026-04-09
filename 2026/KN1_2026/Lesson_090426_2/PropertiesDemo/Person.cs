using System;
using System.Collections.Generic;
using System.Text;

namespace PropertiesDemo
{
    public class Person
    {
        protected string first_name;
        protected string second_name;
        protected int age;
        protected Gender gender;

        public void SendData(params object[] data)
        {
            for(int i = 0; i < data.Length; i++)
            {
                Console.WriteLine($"[{i+1}] >> {data[i]}");
            }
        }

        public Person(string name, int age)
        {
            this.first_name = name.Split(' ')[0];
            second_name = name.Split(" ")[1];
            this.age = age;
        }
        public Person(string name) 
            : this(name, -1)
        {

        }

        public Person()
            :this("Empty")
        {
        }

        public (string,string) GetNames()
        {
            return (first_name, second_name);
        }

        public Gender Gender { get { return gender; } }

        //public string Name
        //{
        //    get
        //    {
        //        return name;
        //    }
        //    set
        //    {
        //        if (!string.IsNullOrEmpty(value))
        //            name = value;
        //    }
        //}

        //public void SetName(string newName) // setter, mutator
        //{
        //    name = newName;
        //}

        //public string GetName() // getter, accessor
        //{
        //    return name;
        //}
    }

}
