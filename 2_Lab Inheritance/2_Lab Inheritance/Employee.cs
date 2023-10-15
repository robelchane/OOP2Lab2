using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Lab_Inheritance
{
	class Employee
	{
		private string id;
		private string name;
		private string address;
		private string phone;
		private long sin;
		private string dateOfBirth;
		private string department;

		/**
		 * Creates an Employee object with default values.
		 */
		public Employee()
		{

		}

		/**
		 * Creates an Employee object providing the id, name, address, phone, address, sin, date of birth and department.
		 * @param id id
		 * @param name name
		 * @param address address
		 * @param phone phone number
		 * @param sin Social Insurance Number
		 * @param dateOfBirth date of birth
		 * @param department department
		 */
		public Employee(string id, string name, string address, string phone, long sin, string dateOfBirth,
				string department)
		{

			this.id = id;
			this.name = name;
			this.address = address;
			this.phone = phone;
			this.sin = sin;
			this.dateOfBirth = dateOfBirth;
			this.department = department;
		}

		/** 
		 * Returns the id.
		 * @return the id
		 */
		public string GetId()
		{
			return id;
		}

		/**
		 * Sets the id to the id provided. 
		 * @param id the id to Set
		 */
		public void SetId(string id)
		{
			this.id = id;
		}

		/**
		 * Returns the name.
		 * @return the name
		 */
		public string GetName()
		{
			return name;
		}

		/**
		 * Sets the name to the name provided.
		 * @param name the name to Set
		 */
		public void SetName(string name)
		{
			this.name = name;
		}

		/**
		 * Returns the address.
		 * @return the address
		 */
		public string GetAddress()
		{
			return address;
		}

		/**
		 * Sets the address to the provided address.
		 * @param address the address to Set
		 */
		public void SetAddress(string address)
		{
			this.address = address;
		}

		/**
		 * Returns the phone number.
		 * @return the phone phone number
		 */
		public string GetPhone()
		{
			return phone;
		}

		/**
		 * Sets the phone number to the phone number provided.
		 * @param phone the phone number to Set
		 */
		public void SetPhone(string phone)
		{
			this.phone = phone;
		}

		/**
		 * Returns Social Insurance Number. 
		 * @return the Social Insurance Number
		 */
		public long GetSin()
		{
			return sin;
		}

		/**
		 * Sets the sin to the Social Insurance Number provided.
		 * @param sin the Social Insurance Number to Set
		 */
		public void SetSin(long sin)
		{
			this.sin = sin;
		}

		/**
		 * Returns the date of birth.
		 * @return the dateOfBirth
		 */
		public string GetDateOfBirth()
		{
			return dateOfBirth;
		}

		/**
		 * Sets the date of birth to the date of birth provided.
		 * @param dateOfBirth the date of birth to Set
		 */
		public void SetDateOfBirth(string dateOfBirth)
		{
			this.dateOfBirth = dateOfBirth;
		}

		/**
		 * Returns the department. 
		 * @return the department
		 */
		public string GetDepartment()
		{
			return department;
		}

		/** 
		 * Sets department to the department provided.
		 * @param department the department to Set
		 */
		public void SetDepartment(string department)
		{
			this.department = department;
		}


		public string tostring()
		{
			return "Employee ID=" + GetId() + ", name=" + GetName() + ", address=" + GetAddress()
					+ ", phone)=" + GetPhone() + ", SIN=" + GetSin() + ", date of birth=" + GetDateOfBirth()
					+ ", department=" + GetDepartment();
		}




	}
}
