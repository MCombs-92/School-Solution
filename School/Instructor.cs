using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School {
	class Instructor : Employee {

		public string Technology { get; set; }
		public bool TeachBootcamps { get; set; } = false;


		public Instructor() {

		}

		public Instructor(string name, string email, string phone, string jobtitle, decimal salary, string technology) : base(name, email, phone, jobtitle, salary) {
			Technology = technology;
		}



	}
}
