using Api.MontreTaCollection.Business.Dto.Watch;
using Api.MontreTaCollection.Business.Mapper.Watch;
using Api.MontreTaCollection.Business.Service.Contract;
using Api.MontreTaCollection.Data.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.MontreTaCollection.Business.Service
{
    public class WatchService : IWatchService
    {
        private readonly IWatchRepository _watchRepository;
        private readonly ICommonRepository _commonRepository;

        public WatchService (IWatchRepository watchRepository, ICommonRepository commonRepository)
        {
            _watchRepository = watchRepository;
            _commonRepository = commonRepository;
        }

        public async Task<List<ReadWatchDto>> GetWatchesAsync()
        {
            var watches = await _watchRepository.GetWatchesAsync().ConfigureAwait(false);
            List<ReadWatchDto> readWatchDtos = new List<ReadWatchDto>();

            foreach (var watch in watches) 
            {
                readWatchDtos.Add(WatchMapper.TransformEntityToReadWatchDto(watch));
            }

            return readWatchDtos;
        }

        public async Task<ReadWatchDto> CreateWatchAsync(CreateWatchDto watchDto)
        {
            if(watchDto == null)
            {
                throw new ArgumentNullException(nameof(watchDto));
            }

            var model = await _commonRepository.GetModelByIdAsync(watchDto.ModelId).ConfigureAwait(false);
            if(model == null)
            {
                throw new Exception("Il n'existe aucun model avec cet identifiant");
            }

            var strapMaterial = await _commonRepository.GetStrapMaterialByIdAsync(watchDto.StrapMaterialId).ConfigureAwait(false);
            if (strapMaterial == null)
            {
                throw new Exception("Il n'existe aucun strap material avec cet identifiant");
            }

            var caseMaterial = await _commonRepository.GetCaseMaterialByIdAsync(watchDto.CaseMaterialId).ConfigureAwait(false);
            if (caseMaterial == null)
            {
                throw new Exception("Il n'existe aucun case material avec cet identifiant");
            }

            var glassMaterial = await _commonRepository.GetGlassMaterialByIdAsync(watchDto.GlassMaterialId).ConfigureAwait(false);
            if (glassMaterial == null)
            {
                throw new Exception("Il n'existe aucun glass material avec cet identifiant");
            }

            var movement = await _commonRepository.GetMovementByIdAsync(watchDto.MovementId).ConfigureAwait(false);
            if (movement == null)
            {
                throw new Exception("Il n'existe aucun movement avec cet identifiant");
            }

            var watchToAdd = WatchMapper.TransformCreateDtoToEntity(watchDto);

            var watchAdded = await _watchRepository.CreateWatchAsync(watchToAdd).ConfigureAwait(false);

            return WatchMapper.TransformEntityToReadWatchDto(watchAdded);
        }
    }
}
