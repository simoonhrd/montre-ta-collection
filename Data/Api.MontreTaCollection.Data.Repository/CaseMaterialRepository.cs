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
    public class CaseMaterialRepository : ICaseMaterialRepository
    {
        private readonly IMontreTaCollectionDBContext _montreTaCollectionDBContext;

        public CaseMaterialRepository(IMontreTaCollectionDBContext montreTaCollectionDBContext)
        {
            _montreTaCollectionDBContext = montreTaCollectionDBContext;
        }

        /// <summary>
        /// This method creates a CaseMaterial
        /// </summary>
        /// <param name="CaseMaterial"></param>
        /// <returns></returns>
        public async Task<CaseMaterial> CreateCaseMaterialAsync(CaseMaterial CaseMaterial)
        {
            var CaseMaterialAdded = await _montreTaCollectionDBContext.CaseMaterials.AddAsync(CaseMaterial).ConfigureAwait(false);
            await _montreTaCollectionDBContext.SaveChangesAsync().ConfigureAwait(false);

            return CaseMaterialAdded.Entity;
        }

        /// <summary>
        /// This method deletes a CaseMaterial
        /// </summary>
        /// <param name="CaseMaterial"></param>
        /// <returns></returns>
        public async Task<CaseMaterial> DeleteCaseMaterialAsync(CaseMaterial CaseMaterial)
        {
            var CaseMaterialDeleted = _montreTaCollectionDBContext.CaseMaterials.Remove(CaseMaterial);
            await _montreTaCollectionDBContext.SaveChangesAsync().ConfigureAwait(false);

            return CaseMaterialDeleted.Entity;
        }

        /// <summary>
        /// This method updates a CaseMaterial
        /// </summary>
        /// <param name="CaseMaterial"></param>
        /// <returns></returns>
        public async Task<CaseMaterial> UpdateCaseMaterialAsync(CaseMaterial CaseMaterial)
        {
            var CaseMaterialUpdated = _montreTaCollectionDBContext.CaseMaterials.Update(CaseMaterial);
            await _montreTaCollectionDBContext.SaveChangesAsync().ConfigureAwait(false);

            return CaseMaterialUpdated.Entity;
        }

        /// <summary>
        /// This method return complete list of CaseMaterials
        /// </summary>
        /// <returns></returns>
        public async Task<List<CaseMaterial>> GetCaseMaterialsAsync()
        {
            return await _montreTaCollectionDBContext.CaseMaterials.ToListAsync().ConfigureAwait(false);
        }
    }
}
