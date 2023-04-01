using System;
using System.Collections.Generic;

namespace M01S09.Aula04.DatabaseFirst.Models;

public partial class Massa
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public virtual ICollection<Pizza> Pizzas { get; } = new List<Pizza>();
}
