using Api.MontreTaCollection.Data.Entity.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.MontreTaCollection.Data.Context.Contract
{
    public interface IMontreTaCollectionDBContext : IDbContext
    {
        DbSet<Brand> Brands { get; set; }

        DbSet<CaseMaterial> CaseMaterials { get; set; }

        DbSet<GlassMaterial> GlassMaterials { get; set; }

        DbSet<Api.MontreTaCollection.Data.Entity.Model.Model> Models { get; set; }

        DbSet<MovementType> MovementTypes { get; set; }

        DbSet<StrapMaterial> StrapMaterials { get; set; }

        DbSet<Watch> Watches { get; set; }
    }
}
