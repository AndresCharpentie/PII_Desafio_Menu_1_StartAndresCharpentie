using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa una mesa en el restaurante.
    /// </summary>
    public class Table
    {
        private List<Dish> order = new List<Dish>();
        
        public int Number { get; private set; }         // Número identificador de la mesa
        public bool IsOccupied { get; private set; }   // Estado de la mesa, ocupado/libre
        
        public Table(int number, bool isOccupied = false)
        {
            Number = number;
            IsOccupied = isOccupied;
        }
        
        // Mesa ocupada
        public void Ocupy()
        {
            this.IsOccupied = true;
        }

        // Libera la mesa y limpia los pedidos
        public void Free()
        {
            this.IsOccupied = false;
            order.Clear();
        }
        
        //Añade otro platillo a la lsita 
        public void AddToOrder(Dish dish)
        {
            order.Add(dish);
        }
        
        // Retorna si la mesa tiene pedidos
        public bool HasOrders()
        {
            return this.order.Count > 0;
        }
       
        
    }
}