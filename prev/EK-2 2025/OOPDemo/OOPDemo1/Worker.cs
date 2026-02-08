namespace OOPDemo1
{
    public class Worker 
    {
        protected string name;
        protected int age;
        protected double salary;
        protected double bonus = 0;

        public Worker() : this("-", 0, 0) { }       
        public Worker(string name, int age) : this(name, age, 0) { }       
        public Worker(string name, int age, double salary)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
        }

        public void SetBonus(double bonus)
        {
            if (bonus >= 0 && bonus <= 1)
                this.bonus = bonus;
        }

        public double GetTotalSalary()
        {
            return salary + salary * bonus; 
        }

        public double Salary
        {
            get { return salary; }
            set { if (value >= 0) salary = value; }
        }

        public double GetSalary() // getter, accessor
        {
            return salary;
        }

        public void SetSalary(double new_salary) // setter, mutator
        {
            if(new_salary >= 0)
                salary = new_salary;
        }

        public override string ToString()
        {
            return $"Worker: {name}: {age} years old, ${GetTotalSalary()}";
        }
    }
}
