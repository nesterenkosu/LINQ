using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWinForms.Entities
{
    class Employee
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual int Age { get; set; }
        public virtual int PositionId { get; set; }
        public virtual double Rate { get; set; }
    }
}
