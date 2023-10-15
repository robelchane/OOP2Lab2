using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Lab_Inheritance
{
	class Salaried : Employee
	{
		private double salary;

		/**
		 * Creates a Salaried object with default values.
		 */
		public Salaried()
		{

		}

		/**
		 * Creates a Salaried object providing the id, name, address, phone, address, sin, date of birth, department, and salary.
		 * @param id id
		 * @param name name
		 * @param address address
		 * @param phone phone number
		 * @param sin Social Insurance Number
		 * @param dateOfBirth date of birth
		 * @param department department
		 * @param salary salary
		 */
		public Salaried(string id, string name, string address, string phone, long sin, string dateOfBirth,
				string department, double salary) : base(id, name, address, phone, sin, dateOfBirth, department)
		{

			this.salary = salary;
		}

		/**
		 * Returns the salary.
		 * @return the salary
		 */
		public double GetSalary()
		{
			return salary;
		}

		/**
		 * Sets the salary to the salary provided.
		 * @param salary the salary to Set
		 */
		public void SetSalary(double salary)
		{
			this.salary = salary;
		}

		/**
		 * Returns the pay.
		 * @return the pay
		 */
		public double GetPay()
		{
			return salary;
		}


		public string tostring()
		{
			return "Salaried ID =" + GetId() + ", name =" + GetName() + ", address =" + GetAddress()
					+ ", phone =" + GetPhone() + ", SIN =" + GetSin() + ", date of birth =" + GetDateOfBirth()
					+ ", department =" + GetDepartment() + ", salary =" + GetSalary() + ", pay =" + GetPay();
		}

	}
}