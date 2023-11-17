using Api.MontreTaCollection.Data.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.MontreTaCollection.Data.Repository.Contract
{
    public interface ICommonRepository
    {
        /// <summary>
        /// This method return Case Material informations by her identifier
        /// </summary>
        /// <param name="caseMaterialId"></param>
        /// <returns></returns>
        Task<CaseMaterial> GetCaseMaterialByIdAsync(int caseMaterialId);

        /// <summary>
        /// This method return Glass Material informations by her identifier
        /// </summary>
        /// <param name="glassMaterialId"></param>
        /// <returns></returns>
        Task<GlassMaterial> GetGlassMaterialByIdAsync(int glassMaterialId);

        /// <summary>
        /// This method return Glass Material informations by her identifier
        /// </summary>
        /// <param name="strapMaterialId"></param>
        /// <returns></returns>
        Task<StrapMaterial> GetStrapMaterialByIdAsync(int strapMaterialId);

        /// <summary>
        /// This method return Glass Material informations by her identifier
        /// </summary>
        /// <param name="modelId"></param>
        /// <returns></returns>
        Task<Model> GetModelByIdAsync(int modelId);

        /// <summary>
        /// This method return Glass Material informations by her identifier
        /// </summary>
        /// <param name="brandId"></param>
        /// <returns></returns>
        Task<Brand> GetBrandByIdAsync(int brandId);

        /// <summary>
        /// This method return Glass Material informations by her identifier
        /// </summary>
        /// <param name="movementId"></param>
        /// <returns></returns>
        Task<MovementType> GetMovementByIdAsync(int movementId);
    }
}
