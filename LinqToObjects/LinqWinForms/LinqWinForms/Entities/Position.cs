using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWinForms.Entities
{
    class Position
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual int Salary { get; set; }
    }
}
