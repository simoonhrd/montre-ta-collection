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
    public class WatchRepository : IWatchRepository
    {
        private readonly IMontreTaCollectionDBContext _montreTaCollectionDBContext;

        public WatchRepository(IMontreTaCollectionDBContext montreTaCollectionDBContext)
        {
            _montreTaCollectionDBContext = montreTaCollectionDBContext;
        }

        /// <summary>
        /// This method creates a Watch
        /// </summary>
        /// <param name="Watch"></param>
        /// <returns></returns>
        public async Task<Watch> CreateWatchAsync(Watch Watch)
        {
            var WatchAdded = await _montreTaCollectionDBContext.Watches.AddAsync(Watch).ConfigureAwait(false);
            await _montreTaCollectionDBContext.SaveChangesAsync().ConfigureAwait(false);

            return WatchAdded.Entity;
        }

        /// <summary>
        /// This method deletes a Watch
        /// </summary>
        /// <param name="Watch"></param>
        /// <returns></returns>
        public async Task<Watch> DeleteWatchAsync(Watch Watch)
        {
            var WatchDeleted = _montreTaCollectionDBContext.Watches.Remove(Watch);
            await _montreTaCollectionDBContext.SaveChangesAsync().ConfigureAwait(false);

            return WatchDeleted.Entity;
        }

        /// <summary>
        /// This method updates a Watch
        /// </summary>
        /// <param name="Watch"></param>
        /// <returns></returns>
        public async Task<Watch> UpdateWatchAsync(Watch Watch)
        {
            var WatchUpdated = _montreTaCollectionDBContext.Watches.Update(Watch);
            await _montreTaCollectionDBContext.SaveChangesAsync().ConfigureAwait(false);

            return WatchUpdated.Entity;
        }

        /// <summary>
        /// This method return complete list of Watches
        /// </summary>
        /// <returns></returns>
        public async Task<List<Watch>> GetWatchesAsync()
        {
            return await _montreTaCollectionDBContext.Watches
            .Include(x => x.Model)
            .Include(x => x.CaseMaterial)
            .Include(x => x.StrapMaterial)
            .Include(x => x.GlassMaterial)
            .Include(x => x.Movement)
            .ToListAsync()
            .ConfigureAwait(false);
        }

        /// <summary>
        /// This method return Watch informations by her identifier
        /// </summary>
        /// <param name="watchId"></param>
        /// <returns></returns>
        public async Task<Watch> GetWatchByIdAsync(int watchId)
        {
            return await _montreTaCollectionDBContext.Watches
                .Include(x => x.Movement)
                .Include(x => x.CaseMaterial)
                .Include(x => x.StrapMaterial)
                .Include(x => x.GlassMaterial)
                .Include(x => x.Movement)
                .FirstOrDefaultAsync(x => x.WatchId == watchId)
                .ConfigureAwait(false);
        }
    }
}
