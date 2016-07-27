using System;
using System.Collections.ObjectModel;

namespace HelloForm
{
	public static class ItemSource
	{
		static ItemSource()
		{
		}

		public static ObservableCollection<Item> getLights()
		{
			ObservableCollection<Item> items = new ObservableCollection<Item>() {
				new Item("Bedside"),
				new Item("Desk"),
				new Item("Flood Lamp"),
				new Item("Hallway"),
				new Item("Hallway 2")
			};
			return items;
		}
	}
}

