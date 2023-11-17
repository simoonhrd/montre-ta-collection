using Api.MontreTaCollection.Data.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.MontreTaCollection.Data.Repository.Contract
{
    public interface IWatchRepository
    {
        /// <summary>
        /// This method creates a Watch
        /// </summary>
        /// <param name="Watch"></param>
        /// <returns></returns>
        Task<Watch> CreateWatchAsync(Watch Watch);

        /// <summary>
        /// This method deletes a Watch
        /// </summary>
        /// <param name="Watch"></param>
        /// <returns></returns>
        Task<Watch> DeleteWatchAsync(Watch Watch);

        /// <summary>
        /// This method updates a Watch
        /// </summary>
        /// <param name="Watch"></param>
        /// <returns></returns>
        Task<Watch> UpdateWatchAsync(Watch Watch);

        /// <summary>
        /// This method return complete list of Watchs
        /// </summary>
        /// <returns></returns>
        Task<List<Watch>> GetWatchesAsync();

        /// <summary>
        /// This method return Watch informations by her identifier
        /// </summary>
        /// <param name="watchId"></param>
        /// <returns></returns>
        Task<Watch> GetWatchByIdAsync(int watchId);
    }
}
