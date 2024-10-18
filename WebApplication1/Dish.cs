using System;
using System.Collections.Generic;

namespace WebApplication1;

public partial class Dish
{
    public int DishId { get; set; }

    public int DishTypeId { get; set; }

    public string? DishName { get; set; }

    public string? DishIngridients { get; set; }
}
