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
    public class MovementTypeRepository : IMovementTypeRepository
    {
        private readonly IMontreTaCollectionDBContext _montreTaCollectionDBContext;

        public MovementTypeRepository(IMontreTaCollectionDBContext montreTaCollectionDBContext)
        {
            _montreTaCollectionDBContext = montreTaCollectionDBContext;
        }

        /// <summary>
        /// This method creates a MovementType
        /// </summary>
        /// <param name="MovementType"></param>
        /// <returns></returns>
        public async Task<MovementType> CreateMovementTypeAsync(MovementType MovementType)
        {
            var MovementTypeAdded = await _montreTaCollectionDBContext.MovementTypes.AddAsync(MovementType).ConfigureAwait(false);
            await _montreTaCollectionDBContext.SaveChangesAsync().ConfigureAwait(false);

            return MovementTypeAdded.Entity;
        }

        /// <summary>
        /// This method deletes a MovementType
        /// </summary>
        /// <param name="MovementType"></param>
        /// <returns></returns>
        public async Task<MovementType> DeleteMovementTypeAsync(MovementType MovementType)
        {
            var MovementTypeDeleted = _montreTaCollectionDBContext.MovementTypes.Remove(MovementType);
            await _montreTaCollectionDBContext.SaveChangesAsync().ConfigureAwait(false);

            return MovementTypeDeleted.Entity;
        }

        /// <summary>
        /// This method updates a MovementType
        /// </summary>
        /// <param name="MovementType"></param>
        /// <returns></returns>
        public async Task<MovementType> UpdateMovementTypeAsync(MovementType MovementType)
        {
            var MovementTypeUpdated = _montreTaCollectionDBContext.MovementTypes.Update(MovementType);
            await _montreTaCollectionDBContext.SaveChangesAsync().ConfigureAwait(false);

            return MovementTypeUpdated.Entity;
        }

        /// <summary>
        /// This method return complete list of MovementTypes
        /// </summary>
        /// <returns></returns>
        public async Task<List<MovementType>> GetMovementTypesAsync()
        {
            return await _montreTaCollectionDBContext.MovementTypes.ToListAsync().ConfigureAwait(false);
        }
    }
}
