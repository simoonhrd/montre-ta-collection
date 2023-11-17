using System;
using System.Collections.Generic;

namespace Api.MontreTaCollection.Data.Entity.Model;

public partial class GlassMaterial
{
    public int GlassMaterialId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Watch> Watches { get; set; } = new List<Watch>();
}
