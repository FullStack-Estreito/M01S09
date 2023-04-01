using System;
using System.Collections.Generic;

namespace M01S09.Aula04.DatabaseFirst.Models;

public partial class Pizza
{
    public int Id { get; set; }

    public int IdMassa { get; set; }

    public int IdBordas { get; set; }

    public virtual Borda IdBordasNavigation { get; set; } = null!;

    public virtual Massa IdMassaNavigation { get; set; } = null!;

    public virtual ICollection<Pedido> Pedidos { get; } = new List<Pedido>();

    public virtual ICollection<PizzaSabore> PizzaSabores { get; } = new List<PizzaSabore>();
}
