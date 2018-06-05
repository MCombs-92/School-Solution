using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School {
	class Program {
		static void Main(string[] args) {

			Student s1 = new Student("s1", "s1@gmail", "513-555-2005", false, false, 4.0);
			Instructor i1 = new Instructor("i1", "i1@gmail.com", "513-555-5001", "Boot Camp Instructor", 75000.00m, "C Sharp");
			Sales sa1 = new Sales("Lisa", "lisa@gmail.com", "12345", "Sales", 150000, "US", 2000000);
			sa1.TotalSales = 23000;
			Operations OP1 = new Operations("Larry", "larry@gmail.com", "1234556", "SuperOp", 3000000);

			List<Person> people = new List<Person>();
			people.Add(s1);
			people.Add(i1);
			people.Add(sa1);
			people.Add(OP1);

			decimal totalsales = 0;
			foreach(Person person in people) {
				Sales sales = person as Sales;
				if(sales != null) {
					totalsales += sales.TotalSales;
					
				}
			}
			Console.WriteLine($"Total sales is {totalsales}");
		}
	}
}
