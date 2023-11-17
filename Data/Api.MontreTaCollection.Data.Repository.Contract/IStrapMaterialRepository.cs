using Api.MontreTaCollection.Data.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.MontreTaCollection.Data.Repository.Contract
{
    public interface IStrapMaterialRepository
    {
        /// <summary>
        /// This method creates a StrapMaterial
        /// </summary>
        /// <param name="StrapMaterial"></param>
        /// <returns></returns>
        Task<StrapMaterial> CreateStrapMaterialAsync(StrapMaterial StrapMaterial);

        /// <summary>
        /// This method deletes a StrapMaterial
        /// </summary>
        /// <param name="StrapMaterial"></param>
        /// <returns></returns>
        Task<StrapMaterial> DeleteStrapMaterialAsync(StrapMaterial StrapMaterial);

        /// <summary>
        /// This method updates a StrapMaterial
        /// </summary>
        /// <param name="StrapMaterial"></param>
        /// <returns></returns>
        Task<StrapMaterial> UpdateStrapMaterialAsync(StrapMaterial StrapMaterial);

        /// <summary>
        /// This method return complete list of StrapMaterials
        /// </summary>
        /// <returns></returns>
        Task<List<StrapMaterial>> GetStrapMaterialsAsync();
    }
}
