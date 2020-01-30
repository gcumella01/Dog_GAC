using System;
using System.Collections.Generic;
using System.Text;
/**
* This class models a Dog.
* @author Gage Cumella
* @version 1.0
* Lab02-Solution
* SP19
*
*/

namespace Dog_project1
{
	public class Dog_Project1

	{


		private int age;
		private String name;
		private object c;

		public object Character { get; private set; }

		/**
		 * Empty-argument constructor to put object
		 * into a consistent state.
		 */
		Dog_Project1()
		{
			age = 0;
			name = "";
		}//end constructor

		/**
		 * Constructor accepts the age and
		 * name of the dog. This is the preferred
		 * constructor.
		 * @param age
		 * @param name
		 */
		public Dog_Project1(int age, String name)
		{

			this.setAge(age);
			this.setName(name);

		}//end constructor

		public int calcDogYears()
		{
			int dogYears = 15 + (this.age - 1) * 7;
			return dogYears;
		}

		/**
		 * Getter for age
		 * @return
		 */
		public int getAge()
		{
			return age;
		}//end getAge

		/**
		 * Setter for age
		 * Checks the bounds so 
		 * @param age
		 */
		public void setAge(int age)
		{
			if (age < 0)
				this.age = 0;
			else
				this.age = age;
		}//end setAge

		/**
		 * Getter for name
		 * @return
		 */
		public String getName()
		{
			return name;
		}//end getName

		/**
		 * Setter for name. Ensures that only
		 * alpha characters are allowed in the name.
		 * @param name
		 */
		public void setName(String name)
		{
			char[] n = name.ToCharArray();

			for (char c; ;)
			{
				;
			}

			{
			}

		}//end setName

		private class Override
		{ }
		public new string ToString => "Dog [age=" + age + ", name=" + name + "]";
	}

}//end class