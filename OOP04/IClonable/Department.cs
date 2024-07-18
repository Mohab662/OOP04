﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.IClonable
{
    internal class Department:ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public object Clone()
        {
            return new Department
            {
                Id = this.Id,
                Name = this.Name
            };
        }

        public override string ToString()
        {
            return $"Id : {Id},Name : {Name}";
        }
    }
}
