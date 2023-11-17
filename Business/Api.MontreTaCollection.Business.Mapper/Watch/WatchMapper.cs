using Api.MontreTaCollection.Business.Dto.Watch;
using Api.MontreTaCollection.Data.Entity.Model;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.MontreTaCollection.Business.Mapper.Watch
{
    public static class WatchMapper
    {
        /// <summary>
        /// Transform watch DTO to Entity
        /// </summary>
        /// <param name="createWatchDto"></param>
        /// <returns></returns>
        public static Data.Entity.Model.Watch TransformCreateDtoToEntity(CreateWatchDto createWatchDto)
        {
            return new Data.Entity.Model.Watch()
            {
                Title = createWatchDto.Title,
                ProductionDate = createWatchDto.ProductionDate,
                CaseMaterialId = createWatchDto.CaseMaterialId,
                GlassMaterialId = createWatchDto.GlassMaterialId,
                ModelId = createWatchDto.ModelId,
                MovementId = createWatchDto.MovementId,
                StrapMaterialId = createWatchDto.StrapMaterialId,
                ImageUrl = createWatchDto.ImageUrl,
            };
        }

        public static ReadWatchDto TransformEntityToReadWatchDto(Data.Entity.Model.Watch watch)
        {
            return new ReadWatchDto()
            {
                WatchId = watch.WatchId,
                Title = watch.Title,
                ProductionDate = watch.ProductionDate,
                CaseMaterialId = watch.CaseMaterialId,
                CaseMaterialName = watch.CaseMaterial.Name,
                GlassMaterialId = watch.GlassMaterialId,
                GlassMaterialName = watch.GlassMaterial.Name,
                ModelId = watch.ModelId,
                ModelName = watch.Model.Name,
                MovementId = watch.MovementId,
                MovementTypeName = watch.Movement.Name,
                StrapMaterialId = watch.StrapMaterialId,
                StrapMaterialName = watch.StrapMaterial.Name,
                ImageUrl = watch.ImageUrl,
            };
        }
    }
}
