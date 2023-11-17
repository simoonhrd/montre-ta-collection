using Api.MontreTaCollection.Business.Dto.Watch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.MontreTaCollection.Business.Service.Contract
{
    public interface IWatchService
    {
        Task<ReadWatchDto> CreateWatchAsync(CreateWatchDto watchDto);

        Task<List<ReadWatchDto>> GetWatchesAsync();
    }
}
