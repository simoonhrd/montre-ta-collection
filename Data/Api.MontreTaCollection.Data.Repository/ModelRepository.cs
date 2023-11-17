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
    public class ModelRepository : IModelRepository
    {
        private readonly IMontreTaCollectionDBContext _montreTaCollectionDBContext;

        public ModelRepository(IMontreTaCollectionDBContext montreTaCollectionDBContext)
        {
            _montreTaCollectionDBContext = montreTaCollectionDBContext;
        }

        /// <summary>
        /// This method creates a Model
        /// </summary>
        /// <param name="Model"></param>
        /// <returns></returns>
        public async Task<Model> CreateModelAsync(Model Model)
        {
            var ModelAdded = await _montreTaCollectionDBContext.Models.AddAsync(Model).ConfigureAwait(false);
            await _montreTaCollectionDBContext.SaveChangesAsync().ConfigureAwait(false);

            return ModelAdded.Entity;
        }

        /// <summary>
        /// This method deletes a Model
        /// </summary>
        /// <param name="Model"></param>
        /// <returns></returns>
        public async Task<Model> DeleteModelAsync(Model Model)
        {
            var ModelDeleted = _montreTaCollectionDBContext.Models.Remove(Model);
            await _montreTaCollectionDBContext.SaveChangesAsync().ConfigureAwait(false);

            return ModelDeleted.Entity;
        }

        /// <summary>
        /// This method updates a Model
        /// </summary>
        /// <param name="Model"></param>
        /// <returns></returns>
        public async Task<Model> UpdateModelAsync(Model Model)
        {
            var ModelUpdated = _montreTaCollectionDBContext.Models.Update(Model);
            await _montreTaCollectionDBContext.SaveChangesAsync().ConfigureAwait(false);

            return ModelUpdated.Entity;
        }

        /// <summary>
        /// This method return complete list of Models
        /// </summary>
        /// <returns></returns>
        public async Task<List<Model>> GetModelsAsync()
        {
            return await _montreTaCollectionDBContext.Models.ToListAsync().ConfigureAwait(false);
        }
    }
}
