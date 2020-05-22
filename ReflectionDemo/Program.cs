using System;
using System.Reflection;

namespace ReflectionDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			//Example2.ExampleMethod();
			Book book1 = new Book("chandan", 100,"kids story","pub1");
			Book book2 = new Book("surya", 200,"History","pub2");
			Book book3 = new Book("chitra", 100,"sports","pub3");
			Library lib = new Library("Redmond Library");
			lib.bookDictionary.Add(book1.Author, book1.Price);
			lib.bookDictionary.Add(book2.Author, book2.Price);
			lib.bookDictionary.Add(book3.Author, book3.Price);

			/****** Using indexers*******/
			Console.WriteLine("Accessing the  value by using indexer: "+lib["chandan"]);
			lib["chandan"] = 500;
			Console.WriteLine("After setting the value by indexer lib[chandan]: "+lib["chandan"]);

			/*********using reflection*********/
			Type type=typeof(Book);
			Console.WriteLine(type);
			PropertyInfo[] propertyInfo = type.GetProperties();
			foreach(PropertyInfo info in propertyInfo)
			{
				Console.WriteLine(info);
			}


			
		}
	}
}
