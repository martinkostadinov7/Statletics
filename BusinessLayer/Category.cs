using System;
using System.Collections.Generic;

namespace BusinessLayer;

public partial class Category
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual List<Discipline> Disciplines { get; set; } = new List<Discipline>();
    public Category()
    {
        
    }

}
