using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa un mozo en el restaurante, encargado de atender mesas.
    /// </summary>
    public class Waiter
    {
        public string Name { get; private set; }
        private List<Table> assignedTables = new List<Table>();

        public Waiter(string name)
        {
            this.Name = name;
        }

        public void AssignTable(Table table)
        {
            this.assignedTables.Add(table);
        }

        public void TakeOrder(Table table, Dish dish)
        {
            table.AddToOrder(dish);
        }
    }
}