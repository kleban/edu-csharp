using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    public class WorkerStatic
    {
        private static int _workerCount = 0;

        private string name;
        public int age;
        public double salary;

        public WorkerStatic()
        {
            _workerCount++;
        }
        public static int GetWorkerCount()
        {
            return _workerCount;
        }
        public static void ResetWorkerCount()
        {
            _workerCount = 0;
        }

        public string GetName()
        {
            return name;
        }

        public void SetInfo(string nameOfWorker, int age)
        {
            name = nameOfWorker;
            age = age;
        }

        /// <summary>
        /// Sets the member's information including name, age, and an optional salary. It also calls a demonstration
        /// method after setting the values.
        /// </summary>
        /// <param name="name">Specifies the individual's name to be stored.</param>
        /// <param name="age">Indicates the individual's age to be recorded.</param>
        /// <param name="salary">Defines the individual's salary, with a default value = 1 if not provided.</param>
        public void SetInfo2(string name, int age, double salary = 1)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;

            _demoMethod();
        }

        public void SetInfo3(string name, int age, double salary)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;

            _demoMethod();
        }
        public string GetInfo()
        {
            return $"Name: {name}, Age: {age} y.o., Salary: ${salary} - {_workerCount}";
        }

        private void _demoMethod()
        {

        }
    }
}
