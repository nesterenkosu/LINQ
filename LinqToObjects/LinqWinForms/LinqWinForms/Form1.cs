using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinqWinForms.Entities;

namespace LinqWinForms
{
    public partial class Form1 : Form
    {
        List<Language> languages;
        List<Position> positions;
        List<Employee> employees;
        List<EmployeeLanguages> employeelanguages;
        public Form1()
        {
            InitializeComponent();

            myDataGridView.DataSource = myBindingSource;

            languages = new List<Language>
            {
                new Language{Id=1,Name="C",IsCompiled=true},
                new Language{Id=2,Name="C++",IsCompiled=true},
                new Language{Id=3,Name="C#",IsCompiled=true},
                new Language{Id=4,Name="PHP",IsCompiled=false},
                new Language{Id=5,Name="JS",IsCompiled=false}
            };

            positions = new List<Position>
            {
                new Position{Id=1,Name="Программист",Salary=40000},
                new Position{Id=2,Name="Тестировщик",Salary=35000},
                new Position{Id=3,Name="Дизайнер",Salary=30000},
                new Position{Id=4,Name="Тимлид",Salary=1000000}
            };

            employees = new List<Employee>
            {
                new Employee{Id=1,Name="Андрей",Age=30,PositionId=1,Rate=1},
                new Employee{Id=2,Name="Василий",Age=25,PositionId=1,Rate=0.5},
                new Employee{Id=3,Name="Елена",Age=20,PositionId=3,Rate=1},
                new Employee{Id=4,Name="Сергей",Age=40,PositionId=4,Rate=1},
                new Employee{Id=5,Name="Пётр",Age=35,PositionId=2,Rate=0.8},
                new Employee{Id=6,Name="Анна",Age=32,PositionId=2,Rate=1},
                new Employee{Id=6,Name="Иван",Age=32,PositionId=1,Rate=1}
            };

            employeelanguages = new List<EmployeeLanguages> {
                new EmployeeLanguages{Id=1,EmployeeId=1,LanguageId=1},
                new EmployeeLanguages{Id=2,EmployeeId=1,LanguageId=2},
                new EmployeeLanguages{Id=3,EmployeeId=1,LanguageId=3},
                new EmployeeLanguages{Id=4,EmployeeId=2,LanguageId=4},
                new EmployeeLanguages{Id=5,EmployeeId=2,LanguageId=5},
                new EmployeeLanguages{Id=6,EmployeeId=4,LanguageId=3},
                new EmployeeLanguages{Id=4,EmployeeId=4,LanguageId=4},
                new EmployeeLanguages{Id=5,EmployeeId=4,LanguageId=5},
                new EmployeeLanguages{Id=5,EmployeeId=5,LanguageId=3}
            };
        }

        private void языкиПрограммированияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myBindingSource.DataSource = languages;
        }

        private void должностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myBindingSource.DataSource = positions;
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myBindingSource.DataSource = employees;
        }

        private void сотрудникиДолжностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myBindingSource.DataSource = from employee in employees
                                         join position in positions
                                         on employee.PositionId equals position.Id
                                         select new
                                         {
                                             Id = employee.Id,
                                             Name = employee.Name,
                                             Age = employee.Age,
                                             Position = position.Name,
                                             PositionSalary = position.Salary,
                                             EmployeeRate = employee.Rate,
                                             EmployeeSalary = position.Salary * employee.Rate
                                         };
        }

        private void сотрудникиЯзыкиПрограммированияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myBindingSource.DataSource = from language in languages
                                         join el in employeelanguages
                                         on language.Id equals el.LanguageId                                                                                  
                                         group new { 
                                            LanguageName = language.Name
                                         } by el.EmployeeId into g 
                                         join employee in employees
                                         on g.Key equals employee.Id
                                         select new
                                         {
                                             empId=g.Key,
                                             empName=employee.Name,
                                             empQuantity=g.Count(),
                                             empLanguages= String.Join(",",from gg in g select gg.LanguageName)
                                         };
        }

        private void сотрудникиЯзыкиПрограммированияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            myBindingSource.DataSource = employeelanguages;
        }
    }
}
