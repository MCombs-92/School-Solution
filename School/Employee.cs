using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School {
	abstract class Employee : Person {

		public int EmployeeId { get; set; }
		public decimal Salary { get; private set; }
		public string JobTitle { get; set; }

		public void SetSalary(decimal newsalary) {
			if(newsalary <= 0) {
				throw new ApplicationException("Salary must be positive");
			}
			Salary = newsalary;
		}

		public Employee() {

		}

		public Employee(string name, string email, string phone, string jobtitle, decimal salary) : base(name, email, phone, true) {
			JobTitle = jobtitle;
			SetSalary(salary);
		}

	}
}
