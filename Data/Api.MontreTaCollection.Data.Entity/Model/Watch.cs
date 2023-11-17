using System;
using System.Collections.Generic;

namespace Api.MontreTaCollection.Data.Entity.Model;

public partial class Watch
{
    public int WatchId { get; set; }

    public string Title { get; set; } = null!;

    public short? ProductionDate { get; set; }

    public string? ImageUrl { get; set; }

    public int CaseMaterialId { get; set; }

    public int MovementId { get; set; }

    public int ModelId { get; set; }

    public int StrapMaterialId { get; set; }

    public int GlassMaterialId { get; set; }

    public virtual CaseMaterial CaseMaterial { get; set; } = null!;

    public virtual GlassMaterial GlassMaterial { get; set; } = null!;

    public virtual Model Model { get; set; } = null!;

    public virtual MovementType Movement { get; set; } = null!;

    public virtual StrapMaterial StrapMaterial { get; set; } = null!;
}
