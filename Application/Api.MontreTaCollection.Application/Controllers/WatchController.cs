using Api.MontreTaCollection.Business.Dto.Watch;
using Api.MontreTaCollection.Business.Service.Contract;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.MontreTaCollection.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WatchController : ControllerBase
    {

        private readonly IWatchService _watchService;

        public WatchController(IWatchService watchService)
        {
            _watchService = watchService;
        }


        /// <summary>
        /// Ressource pour recupérer la liste des montres
        /// </summary>
        /// <returns></returns>
        // GET: api/<WatchController>
        [HttpGet]
        [ProducesResponseType(typeof(List<ReadWatchDto>), 200)]
        public async Task<ActionResult> GetElevesAsync()
        {
            var watchDtos = await _watchService.GetWatchesAsync().ConfigureAwait(false);
            return Ok(watchDtos);
        }


        /// <summary>
        /// Ressource pour ajouter une nouvelle montre
        /// </summary>
        /// <param name="watchDto">les informations de la nouvelle montre</param>
        /// <returns></returns>
        // POST api/<WatchController>
        [HttpPost]
        public async Task<ActionResult> CreateWatchAsync([FromBody] CreateWatchDto watchDto)
        {

            if (string.IsNullOrWhiteSpace(watchDto?.Title))
            {
                return BadRequest(new
                {
                    Error = "Les informations utiles pour la création d'une montre sont vides"
                });
            }


            try
            {
                var elementAdded = await _watchService.CreateWatchAsync(watchDto).ConfigureAwait(false);
                return Ok(elementAdded);
            }
            catch (Exception e)
            {
                return BadRequest(new
                {
                    Error = e.Message
                });
            }


        }

        /// <summary>
        /// Ressource pour supprimer une montre
        /// </summary>
        /// <param name="watchId">l'identifiant  de l'élève</param>
        /// <returns></returns>
        // DELETE api/<ElevesController>/5
        /*[HttpDelete("{id}")]
        public async Task<ActionResult> DeleteEleveAsync(int watchId)
        {
            try
            {
                var elementDeleted = await _watchService.DeleteWatchAsync(id).ConfigureAwait(false);
                return Ok(elementDeleted);
            }
            catch (Exception e)
            {
                return BadRequest(new
                {
                    Error = e.Message
                });
            }
        }*/

        // GET api/<ElevesController>/5
        /* [HttpGet("{id}")]
         public string Get(int id)
         {
             return "value";
         }
         // PUT api/<ElevesController>/5
         [HttpPut("{id}")]
         public void Put(int id, [FromBody] string value)
         {
         }

         */
    }
}


