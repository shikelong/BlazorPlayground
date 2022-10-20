namespace BlazingPizza.Data;

public class PizzaService
{
    public Task<List<Pizza>> GetPizzasAsync()
    {
        return Task.FromResult(new List<Pizza>()
        {
            new Pizza
            {
                PizzaId = 0,
                Name = "Pizza A",
                Description = "Description",
                Price = 9.12m,
                Vegetarian = false,
                Vegan = true
            }
        });
    }
}