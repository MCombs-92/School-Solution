using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School {
	class Operations : Employee {

		public Operations() {

		}

		public Operations(string name, string email, string phone, string jobtitle, decimal salary) 
			:base(name, email, phone, jobtitle, salary) {

		}
	}
}

