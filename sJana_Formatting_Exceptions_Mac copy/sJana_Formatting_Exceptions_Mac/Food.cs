using System;
using System.Collections.Generic;
namespace sJana_Formatting_Exceptions_Mac
{
	public class Food 
	{
		
			public string Name {get; set;}
			public double Price { get; set; }
			public bool onionst { get; set; }
			public List<Food> menuy = new List<Food>()
			{
				{new Food("Burger",2.05)},
				{new Food("Double Double",2.05)},
				{new Food("French Fries",1.60)}
			};

			public Food(string Name, double Price, bool onionst )
			{
				this.Name = Name;
				this.Price = Price;
				this.onionst = onionst;
			}
			public Food(string Name, double Price)
			{
				this.Name = Name;
				this.Price = Price;
			}
			public Food(string Name)
			{
				this.Name = Name;
				this.Price = Price;
			}
			public Food()
			{
			}
			public List<Food> getMenuy(){
				return menuy;
			}
		public override string ToString ()
		{
			return string.Format ("[Food: Name={0}, Price={1}, With Onions={2}]", Name, Price, onionst);
		}
	}
}

