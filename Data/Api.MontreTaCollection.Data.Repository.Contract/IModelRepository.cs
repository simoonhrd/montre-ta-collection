using Api.MontreTaCollection.Data.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.MontreTaCollection.Data.Repository.Contract
{
    public interface IModelRepository
    {
        /// <summary>
        /// This method creates a Model
        /// </summary>
        /// <param name="Model"></param>
        /// <returns></returns>
        Task<Model> CreateModelAsync(Model Model);

        /// <summary>
        /// This method deletes a Model
        /// </summary>
        /// <param name="Model"></param>
        /// <returns></returns>
        Task<Model> DeleteModelAsync(Model Model);

        /// <summary>
        /// This method updates a Model
        /// </summary>
        /// <param name="Model"></param>
        /// <returns></returns>
        Task<Model> UpdateModelAsync(Model Model);

        /// <summary>
        /// This method return complete list of Models
        /// </summary>
        /// <returns></returns>
        Task<List<Model>> GetModelsAsync();
    }
}
