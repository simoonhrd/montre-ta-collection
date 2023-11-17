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
    public class BrandRepository : IBrandRepository
    {
        private readonly IMontreTaCollectionDBContext _montreTaCollectionDBContext;

        public BrandRepository (IMontreTaCollectionDBContext montreTaCollectionDBContext)
        {
            _montreTaCollectionDBContext = montreTaCollectionDBContext;
        }

        /// <summary>
        /// This method creates a Brand
        /// </summary>
        /// <param name="brand"></param>
        /// <returns></returns>
        public async Task<Brand> CreateBrandAsync(Brand brand)
        {
            var brandAdded = await _montreTaCollectionDBContext.Brands.AddAsync(brand).ConfigureAwait(false);
            await _montreTaCollectionDBContext.SaveChangesAsync().ConfigureAwait(false);

            return brandAdded.Entity;
        }

        /// <summary>
        /// This method deletes a Brand
        /// </summary>
        /// <param name="brand"></param>
        /// <returns></returns>
        public async Task<Brand> DeleteBrandAsync(Brand brand)
        {
            var brandDeleted = _montreTaCollectionDBContext.Brands.Remove(brand);
            await _montreTaCollectionDBContext.SaveChangesAsync().ConfigureAwait(false);

            return brandDeleted.Entity;
        }

        /// <summary>
        /// This method updates a Brand
        /// </summary>
        /// <param name="brand"></param>
        /// <returns></returns>
        public async Task<Brand> UpdateBrandAsync(Brand brand)
        {
            var brandUpdated = _montreTaCollectionDBContext.Brands.Update(brand);
            await _montreTaCollectionDBContext.SaveChangesAsync().ConfigureAwait(false);

            return brandUpdated.Entity;
        }

        /// <summary>
        /// This method return complete list of Brands
        /// </summary>
        /// <returns></returns>
        public async Task<List<Brand>> GetBrandsAsync()
        {
            return await _montreTaCollectionDBContext.Brands.ToListAsync().ConfigureAwait(false);
        }
    }
}
