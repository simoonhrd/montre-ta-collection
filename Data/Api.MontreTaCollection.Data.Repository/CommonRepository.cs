using Api.MontreTaCollection.Data.Context.Contract;
using Api.MontreTaCollection.Data.Entity;
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
    public class CommonRepository : ICommonRepository
    {
        private readonly IMontreTaCollectionDBContext _dbContext;

        public CommonRepository(IMontreTaCollectionDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// This method return Case Material informations by her identifier
        /// </summary>
        /// <param name="caseMaterialId"></param>
        /// <returns></returns>
        public async Task<CaseMaterial> GetCaseMaterialByIdAsync(int caseMaterialId)
        {
            return await _dbContext.CaseMaterials
                .FirstOrDefaultAsync(x => x.CaseMaterialId == caseMaterialId)
                .ConfigureAwait(false);
        }

        /// <summary>
        /// This method return Glass Material informations by her identifier
        /// </summary>
        /// <param name="glassMaterialId"></param>
        /// <returns></returns>
        public async Task<GlassMaterial> GetGlassMaterialByIdAsync(int glassMaterialId)
        {
            return await _dbContext.GlassMaterials
                .FirstOrDefaultAsync(x => x.GlassMaterialId == glassMaterialId)
                .ConfigureAwait(false);
        }

        /// <summary>
        /// This method return Glass Material informations by her identifier
        /// </summary>
        /// <param name="strapMaterialId"></param>
        /// <returns></returns>
        public async Task<StrapMaterial> GetStrapMaterialByIdAsync(int strapMaterialId)
        {
            return await _dbContext.StrapMaterials
                .FirstOrDefaultAsync(x => x.StrapMaterialId == strapMaterialId)
                .ConfigureAwait(false);
        }

        /// <summary>
        /// This method return Glass Material informations by her identifier
        /// </summary>
        /// <param name="modelId"></param>
        /// <returns></returns>
        public async Task<Model> GetModelByIdAsync(int modelId)
        {
            return await _dbContext.Models
                .FirstOrDefaultAsync(x => x.ModelId == modelId)
                .ConfigureAwait(false);
        }

        /// <summary>
        /// This method return Glass Material informations by her identifier
        /// </summary>
        /// <param name="brandId"></param>
        /// <returns></returns>
        public async Task<Brand> GetBrandByIdAsync(int brandId)
        {
            return await _dbContext.Brands
                .FirstOrDefaultAsync(x => x.BrandId == brandId)
                .ConfigureAwait(false);
        }

        /// <summary>
        /// This method return Glass Material informations by her identifier
        /// </summary>
        /// <param name="movementId"></param>
        /// <returns></returns>
        public async Task<MovementType> GetMovementByIdAsync(int movementId)
        {
            return await _dbContext.MovementTypes
                .FirstOrDefaultAsync(x => x.MovementId == movementId)
                .ConfigureAwait(false);
        }
    }
}
