using Api.MontreTaCollection.Data.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.MontreTaCollection.Data.Repository.Contract
{
    public interface IMovementTypeRepository
    {
        /// <summary>
        /// This method creates a MovementType
        /// </summary>
        /// <param name="MovementType"></param>
        /// <returns></returns>
        Task<MovementType> CreateMovementTypeAsync(MovementType MovementType);

        /// <summary>
        /// This method deletes a MovementType
        /// </summary>
        /// <param name="MovementType"></param>
        /// <returns></returns>
        Task<MovementType> DeleteMovementTypeAsync(MovementType MovementType);

        /// <summary>
        /// This method updates a MovementType
        /// </summary>
        /// <param name="MovementType"></param>
        /// <returns></returns>
        Task<MovementType> UpdateMovementTypeAsync(MovementType MovementType);

        /// <summary>
        /// This method return complete list of MovementTypes
        /// </summary>
        /// <returns></returns>
        Task<List<MovementType>> GetMovementTypesAsync();
    }
}
