using System;
using System.Collections.Generic;

namespace Api.MontreTaCollection.Data.Entity.Model;

public partial class Model
{
    public int ModelId { get; set; }

    public string Name { get; set; } = null!;

    public int BrandId { get; set; }

    public virtual Brand Brand { get; set; } = null!;

    public virtual ICollection<Watch> Watches { get; set; } = new List<Watch>();
}
