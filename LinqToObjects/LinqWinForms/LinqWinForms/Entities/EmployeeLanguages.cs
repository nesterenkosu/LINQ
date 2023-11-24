using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWinForms.Entities
{
    class EmployeeLanguages
    {
        public virtual int Id { get; set; }
        public virtual int EmployeeId { get; set; }
        public virtual int LanguageId { get; set; }
    }
}
