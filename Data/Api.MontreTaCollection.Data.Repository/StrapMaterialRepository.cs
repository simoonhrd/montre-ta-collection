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
    public class StrapMaterialRepository : IStrapMaterialRepository
    {
        private readonly IMontreTaCollectionDBContext _montreTaCollectionDBContext;

        public StrapMaterialRepository(IMontreTaCollectionDBContext montreTaCollectionDBContext)
        {
            _montreTaCollectionDBContext = montreTaCollectionDBContext;
        }

        /// <summary>
        /// This method creates a StrapMaterial
        /// </summary>
        /// <param name="StrapMaterial"></param>
        /// <returns></returns>
        public async Task<StrapMaterial> CreateStrapMaterialAsync(StrapMaterial StrapMaterial)
        {
            var StrapMaterialAdded = await _montreTaCollectionDBContext.StrapMaterials.AddAsync(StrapMaterial).ConfigureAwait(false);
            await _montreTaCollectionDBContext.SaveChangesAsync().ConfigureAwait(false);

            return StrapMaterialAdded.Entity;
        }

        /// <summary>
        /// This method deletes a StrapMaterial
        /// </summary>
        /// <param name="StrapMaterial"></param>
        /// <returns></returns>
        public async Task<StrapMaterial> DeleteStrapMaterialAsync(StrapMaterial StrapMaterial)
        {
            var StrapMaterialDeleted = _montreTaCollectionDBContext.StrapMaterials.Remove(StrapMaterial);
            await _montreTaCollectionDBContext.SaveChangesAsync().ConfigureAwait(false);

            return StrapMaterialDeleted.Entity;
        }

        /// <summary>
        /// This method updates a StrapMaterial
        /// </summary>
        /// <param name="StrapMaterial"></param>
        /// <returns></returns>
        public async Task<StrapMaterial> UpdateStrapMaterialAsync(StrapMaterial StrapMaterial)
        {
            var StrapMaterialUpdated = _montreTaCollectionDBContext.StrapMaterials.Update(StrapMaterial);
            await _montreTaCollectionDBContext.SaveChangesAsync().ConfigureAwait(false);

            return StrapMaterialUpdated.Entity;
        }

        /// <summary>
        /// This method return complete list of StrapMaterials
        /// </summary>
        /// <returns></returns>
        public async Task<List<StrapMaterial>> GetStrapMaterialsAsync()
        {
            return await _montreTaCollectionDBContext.StrapMaterials.ToListAsync().ConfigureAwait(false);
        }
    }
}
