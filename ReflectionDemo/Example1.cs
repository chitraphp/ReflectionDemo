using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ReflectionDemo
{
	class Example1
	{
		public static void Demo1()
		{
			Type m1;
			m1 = typeof(int);
			Console.WriteLine(m1.Name + "  " + m1.FullName);

			m1 = typeof(Example1);
			m1 = typeof(int);
			Console.WriteLine(m1.Name + "  " + m1.FullName);
			
		}
		public static void Demo2()
		{
			Type m1 = typeof(Example1);
			MemberInfo[] n;
			n = m1.GetMembers();
			Console.WriteLine(n.Length);
			foreach(MemberInfo a in n)
			{
				Console.WriteLine(a.Name);
			}
		}
	}
}
