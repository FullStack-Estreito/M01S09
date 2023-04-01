using System;
using System.Collections.Generic;

namespace M01S09.Aula04.DatabaseFirst.Models;

public partial class PizzaSabore
{
    public int Id { get; set; }

    public int IdPizza { get; set; }

    public int IdSabores { get; set; }

    public virtual Pizza IdPizzaNavigation { get; set; } = null!;

    public virtual Sabore IdSaboresNavigation { get; set; } = null!;
}
