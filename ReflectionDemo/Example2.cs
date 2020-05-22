using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ReflectionDemo
{
	class Example2
	{
		public static void ExampleMethod()
		{
			Type type;
			type = typeof(DemoClass);
			Console.WriteLine(type.Name);

			foreach (Object obj in type.GetCustomAttributes(true))
				Console.WriteLine(obj);

			foreach(MethodInfo mInfo in type.GetMethods())
			{
				object[] b = mInfo.GetCustomAttributes(true);
				foreach(Attribute a in b)
				{
					Console.WriteLine(a);
				}
			}
		}		
	}

	[AttributeUsage(AttributeTargets.All)]
	class Chitra : System.Attribute
	{
		string s1, s2;
		int i1;
		public int ntest;
		public Chitra(string s,int i)
		{
			s1 = s;
			i1 = i;
		}
		public string Name 
		{			
			get { return s2; }
			set { s2 = value; } 
		}
		
	}

	[Chitra("Hi",100,Name ="chiru",ntest =200)]
	public class DemoClass
	{
		[Chitra("Hi", 100, Name = "chiru2", ntest = 300)]
		public void Demo1() { }
		public int i;
		public void Demo2() { }
	}
}
