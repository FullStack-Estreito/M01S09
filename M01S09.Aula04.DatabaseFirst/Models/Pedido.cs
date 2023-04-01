using System;
using System.Collections.Generic;

namespace M01S09.Aula04.DatabaseFirst.Models;

public partial class Pedido
{
    public int Id { get; set; }

    public int IdPizza { get; set; }

    public int IdStatus { get; set; }

    public virtual Pizza IdPizzaNavigation { get; set; } = null!;

    public virtual StatusPizza IdStatusNavigation { get; set; } = null!;
}
