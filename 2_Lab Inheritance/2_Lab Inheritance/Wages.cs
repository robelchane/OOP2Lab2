using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Lab_Inheritance
{
	class Wages : Employee

	{
		private double rate;
		private double hours;
		private const double REGULAR_HOURS = 40;
		private const double OVERTIME_RATE = 1.5;

		/**
		 * Creates a Wages object with default values.
		 */
		public Wages()
		{

		}

		/**
		 * Creates a Wages object providing the id, name, address, phone, address, sin, date of birth, department, rate, and hours.
		 * @param id id
		 * @param name name
		 * @param address address
		 * @param phone phone number
		 * @param sin Social Insurance Number
		 * @param dateOfBirth date of birth
		 * @param department department
		 * @param rate rate
		 * @param hours hours
		 */
		public Wages(String id, String name, String address, String phone, long sin, String dateOfBirth, String department, double rate, double hours):
			base(id, name, address, phone, sin, dateOfBirth, department)
		{
			
			this.rate = rate;
			this.hours = hours;
		}

		/**
		 * Returns the hourly rate.
		 * @return the hourly rate
		 */
		public double GetRate()
		{
			return rate;
		}

		/**
		 * Sets the hourly rate to the hourly rate provided.
		 * @param rate the hourly rate to Set
		 */
		public void SetRate(double rate)
		{
			this.rate = rate;
		}

		/**
		 * Returns the hours worked.
		 * @return the hours worked
		 */
		public double GetHours()
		{
			return hours;
		}

		/**
		 * Sets the hours to the hours worked.
		 * @param hours the hours worked to Set
		 */
		public void SetHours(double hours)
		{
			this.hours = hours;
		}

		/**
		 * Returns the pay.
		 * @return the pay
		 */
		public double GetPay()
		{
			if (hours <= REGULAR_HOURS)
			{
				return rate * hours;
			}
			else
			{
				return rate * REGULAR_HOURS + rate * OVERTIME_RATE * (hours - REGULAR_HOURS);
			}
		}


		public String toString()
		{
			return "Wages ID =" + GetId() + ", name =" + GetName() + ", address =" + GetAddress()
					+ ", phone =" + GetPhone() + ", SIN =" + GetSin() + ", date of birth =" + GetDateOfBirth()
					+ ", department =" + GetDepartment() + ", rate =" + GetRate() + ", hours =" + GetHours()
					+ ", pay =" + GetPay();
		}


	}
}
