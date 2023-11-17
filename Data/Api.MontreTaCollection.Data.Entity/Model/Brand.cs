using System;
using System.Collections.Generic;

namespace Api.MontreTaCollection.Data.Entity.Model;

public partial class Brand
{
    public int BrandId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Model> Models { get; set; } = new List<Model>();
}
