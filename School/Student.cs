using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School {
	class Student : Person {

		private static int nextid = 1;

		public bool IsVeteran { get; set; } = false;
		public int StudentId { get; set; }
		public double GPA { get; set; }


		public Student() {

		}

		public Student(string name, string email, string phone, bool isemployee, bool isvet, double gpa) : base(name, email, phone, isemployee) {
			IsVeteran = isvet;
			GPA = gpa;
			
		}


	}
}
