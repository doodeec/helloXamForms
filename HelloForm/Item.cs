using System;
using System.ComponentModel;

namespace HelloForm
{
	public class Item
	{
		public Item(string name)
		{
			this._name = name;
		}

		private string _name;

		public string name { get { return _name; } set { _name = value; } }

	}
}

