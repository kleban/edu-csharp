using System;
using System.Collections.Generic;
using System.Text;

namespace GetSetDemo
{
    public class Book
    {
        //public string Name { get; set; }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public Book(string name)
        {
            this.name = name;   
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

       
    }
}
