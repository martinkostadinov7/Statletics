using System;
using System.Collections.Generic;

namespace BusinessLayer;

public partial class Discipline
{
    public int Id { get; set; }

    public int IdCategory { get; set; }

    public string Name { get; set; } = null!;

    public virtual Category IdCategoryNavigation { get; set; } = null!;
    private Discipline()
    {
        
    }

    public Discipline(int idCategory, string name)
    {
        IdCategory = idCategory;
        Name = name;
        IdCategoryNavigation.Id = IdCategory;
    }
}
