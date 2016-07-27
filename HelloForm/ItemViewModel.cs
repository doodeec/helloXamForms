using System;
using System.ComponentModel;
using System.Collections.ObjectModel;
namespace HelloForm
{
	public static class ItemViewModel
	{
		public static ObservableCollection<Item> items { get; set; }

		static ItemViewModel()
		{
			ItemViewModel.items = ItemSource.getLights();
		}
	}
}

