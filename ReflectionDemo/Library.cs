#define DEBUG
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ReflectionDemo
{
	class Library
	{
		public string Name { get; set; }
		public Dictionary<string, decimal> bookDictionary;
		public Library(string name)
		{
			Name = name;
			bookDictionary = new Dictionary<string, decimal>();
		}
		public decimal this[string searchStr]
		{
			get
			{
				return bookDictionary[searchStr];
			}
			set
			{
				bookDictionary[searchStr] = value;
			}
		}
	}
	public class Book
	{		
		public Book(string author, decimal price,string publisher,string title)
		{
			Author = author;
			Price = price;
			Title = title;
			Publisher = publisher;
		
		}		
		public string Author { get; set; }
		public string Title { get; set; }
		public string Publisher { get; set; }
		//public DateTime ReleaseDate { get; set; }
		public decimal Price { get; set; }
	}
}
