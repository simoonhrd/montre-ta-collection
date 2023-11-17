using Api.MontreTaCollection.Data.Context.Contract;
using Api.MontreTaCollection.Data.Entity.Model;
using Api.MontreTaCollection.Data.Repository.Contract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.MontreTaCollection.Data.Repository
{
    public class GlassMaterialRepository : IGlassMaterialRepository
    {
        private readonly IMontreTaCollectionDBContext _montreTaCollectionDBContext;

        public GlassMaterialRepository(IMontreTaCollectionDBContext montreTaCollectionDBContext)
        {
            _montreTaCollectionDBContext = montreTaCollectionDBContext;
        }

        /// <summary>
        /// This method creates a GlassMaterial
        /// </summary>
        /// <param name="GlassMaterial"></param>
        /// <returns></returns>
        public async Task<GlassMaterial> CreateGlassMaterialAsync(GlassMaterial GlassMaterial)
        {
            var GlassMaterialAdded = await _montreTaCollectionDBContext.GlassMaterials.AddAsync(GlassMaterial).ConfigureAwait(false);
            await _montreTaCollectionDBContext.SaveChangesAsync().ConfigureAwait(false);

            return GlassMaterialAdded.Entity;
        }

        /// <summary>
        /// This method deletes a GlassMaterial
        /// </summary>
        /// <param name="GlassMaterial"></param>
        /// <returns></returns>
        public async Task<GlassMaterial> DeleteGlassMaterialAsync(GlassMaterial GlassMaterial)
        {
            var GlassMaterialDeleted = _montreTaCollectionDBContext.GlassMaterials.Remove(GlassMaterial);
            await _montreTaCollectionDBContext.SaveChangesAsync().ConfigureAwait(false);

            return GlassMaterialDeleted.Entity;
        }

        /// <summary>
        /// This method updates a GlassMaterial
        /// </summary>
        /// <param name="GlassMaterial"></param>
        /// <returns></returns>
        public async Task<GlassMaterial> UpdateGlassMaterialAsync(GlassMaterial GlassMaterial)
        {
            var GlassMaterialUpdated = _montreTaCollectionDBContext.GlassMaterials.Update(GlassMaterial);
            await _montreTaCollectionDBContext.SaveChangesAsync().ConfigureAwait(false);

            return GlassMaterialUpdated.Entity;
        }

        /// <summary>
        /// This method return complete list of GlassMaterials
        /// </summary>
        /// <returns></returns>
        public async Task<List<GlassMaterial>> GetGlassMaterialsAsync()
        {
            return await _montreTaCollectionDBContext.GlassMaterials.ToListAsync().ConfigureAwait(false);
        }
    }
}
