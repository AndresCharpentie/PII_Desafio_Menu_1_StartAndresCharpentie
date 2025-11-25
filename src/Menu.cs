using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa el conjunto de platillos <see cref="Dish"/> disponibles en el
    /// restaurante.
    /// </summary>
    public class Menu
    {
        private List<Dish> dishes = new List<Dish>();
        
        public List<Dish> Dishes
        {
            get { return dishes; }
            set { dishes = value; }
        }

        public void AddDish(Dish dish)
        {
            this.dishes.Add(dish);
        }

        public void RemoveDish(Dish dish)
        {
            this.dishes.Remove(dish);
        }

        public Dish GetDishByName(string name)
        {
            foreach (Dish dish in this.dishes)
            {
                if (dish.Name == name)
                {
                    return dish;
                }
            }

            return null;
        }
    }
}
    
  