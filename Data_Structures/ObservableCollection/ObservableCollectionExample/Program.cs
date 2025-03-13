using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservableCollectionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ObservableCollection<string> Items = new ObservableCollection<string>();

            Items.CollectionChanged += Items_CollectionChanged;

            Items.Add("Item 1");
            Items.Add("Item 2");
            Items.Add("Item 3");

            Items.RemoveAt(1);
            Items.Insert(0, "New Item");
            Items[1] = "Replaced Item";
            Items.Move(0, 2);
        }
        static void Items_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine("Collection Changed");
            //Handling Collection Changes
            switch (e.Action)
            {
                case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
                    Console.WriteLine("New Item Added");
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
                    Console.WriteLine("Item Removed");
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
                    Console.WriteLine("Item Replaced");
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Move:
                    Console.WriteLine("Item Moved");
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
                    Console.WriteLine("Collection Reset");
                    break;
                    default:
                    break;
            }
        }
    }
}
