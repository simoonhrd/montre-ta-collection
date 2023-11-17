using Api.MontreTaCollection.Data.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.MontreTaCollection.Data.Repository.Contract
{
    public interface IBrandRepository
    {
        /// <summary>
        /// This method creates a Brand
        /// </summary>
        /// <param name="brand"></param>
        /// <returns></returns>
        Task<Brand> CreateBrandAsync(Brand brand);

        /// <summary>
        /// This method deletes a Brand
        /// </summary>
        /// <param name="brand"></param>
        /// <returns></returns>
        Task<Brand> DeleteBrandAsync(Brand brand);

        /// <summary>
        /// This method updates a Brand
        /// </summary>
        /// <param name="brand"></param>
        /// <returns></returns>
        Task<Brand> UpdateBrandAsync(Brand brand);

        /// <summary>
        /// This method return complete list of Brands
        /// </summary>
        /// <returns></returns>
        Task<List<Brand>> GetBrandsAsync();
    }
}
