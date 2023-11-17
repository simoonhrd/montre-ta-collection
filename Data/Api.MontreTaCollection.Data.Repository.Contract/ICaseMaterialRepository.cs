using Api.MontreTaCollection.Data.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.MontreTaCollection.Data.Repository.Contract
{
    public interface ICaseMaterialRepository
    {
        /// <summary>
        /// This method creates a CaseMaterial
        /// </summary>
        /// <param name="CaseMaterial"></param>
        /// <returns></returns>
        Task<CaseMaterial> CreateCaseMaterialAsync(CaseMaterial CaseMaterial);

        /// <summary>
        /// This method deletes a CaseMaterial
        /// </summary>
        /// <param name="CaseMaterial"></param>
        /// <returns></returns>
        Task<CaseMaterial> DeleteCaseMaterialAsync(CaseMaterial CaseMaterial);

        /// <summary>
        /// This method updates a CaseMaterial
        /// </summary>
        /// <param name="CaseMaterial"></param>
        /// <returns></returns>
        Task<CaseMaterial> UpdateCaseMaterialAsync(CaseMaterial CaseMaterial);

        /// <summary>
        /// This method return complete list of CaseMaterials
        /// </summary>
        /// <returns></returns>
        Task<List<CaseMaterial>> GetCaseMaterialsAsync();
    }
}
