using Api.MontreTaCollection.Data.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.MontreTaCollection.Data.Repository.Contract
{
    public interface IGlassMaterialRepository
    {
        /// <summary>
        /// This method creates a GlassMaterial
        /// </summary>
        /// <param name="GlassMaterial"></param>
        /// <returns></returns>
        Task<GlassMaterial> CreateGlassMaterialAsync(GlassMaterial GlassMaterial);

        /// <summary>
        /// This method deletes a GlassMaterial
        /// </summary>
        /// <param name="GlassMaterial"></param>
        /// <returns></returns>
        Task<GlassMaterial> DeleteGlassMaterialAsync(GlassMaterial GlassMaterial);

        /// <summary>
        /// This method updates a GlassMaterial
        /// </summary>
        /// <param name="GlassMaterial"></param>
        /// <returns></returns>
        Task<GlassMaterial> UpdateGlassMaterialAsync(GlassMaterial GlassMaterial);

        /// <summary>
        /// This method return complete list of GlassMaterials
        /// </summary>
        /// <returns></returns>
        Task<List<GlassMaterial>> GetGlassMaterialsAsync();
    }
}
