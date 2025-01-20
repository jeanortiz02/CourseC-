using System;
using System.Collections.Generic;

namespace BD;

public partial class Marca
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Beer> Beers { get; set; } = new List<Beer>();
}
