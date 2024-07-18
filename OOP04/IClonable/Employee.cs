using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.IClonable
{
    internal class Employee : ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Department Department { get; set; }

        public object Clone()
        {
            return new Employee(this)
            {
                //Id = this.Id,
                //Name = this.Name,
                //Salary = this.Salary,
                //Department = (Department)this.Department.Clone()
            };
        }

        public Employee(Employee employee)
        {
            this.Id = employee.Id;
            this.Name = employee.Name;
            this.Salary = employee.Salary;
            this.Department=(Department)employee.Department.Clone();
        }
        public override string ToString()
        {
            return $"Id : {Id},Name : {Name},Salary : {Salary} , Department : {Department}";
        }
    }
}
