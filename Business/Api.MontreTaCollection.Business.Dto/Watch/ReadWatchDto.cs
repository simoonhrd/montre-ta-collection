using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.MontreTaCollection.Business.Dto.Watch
{
    public class ReadWatchDto
    {
        public int WatchId { get; set; }
        
        /// <summary>
        /// Title of your watch.
        /// </summary>
        /// <value>
        /// Title
        /// </value>
        public string Title { get; set; } = null!;

        /// <summary>
        /// Year of your watch.
        /// </summary>
        /// <value>
        /// Year
        /// </value>
        public short? ProductionDate { get; set; }

        /// <summary>
        /// Picture of your watch.
        /// </summary>
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Case material identifier of your watch.
        /// </summary>
        /// <value>
        /// Case material id
        /// </value>
        public int CaseMaterialId { get; set; }
        public string? CaseMaterialName { get; set; }

        /// <summary>
        /// Movement identifier of your watch.
        /// </summary>
        /// <value>
        /// Movement id
        /// </value>
        public int MovementId { get; set; }
        public string? MovementTypeName { get; set; }

        /// <summary>
        /// Model identifier of your watch.
        /// </summary>
        /// <value>
        /// Model id
        /// </value>
        public int ModelId { get; set; }
        public string? ModelName { get; set; }

        /// <summary>
        /// Strap material identifier of your watch.
        /// </summary>
        /// <value>
        /// Strap material id
        /// </value>
        public int StrapMaterialId { get; set; }
        public string? StrapMaterialName { get; set; }

        /// <summary>
        /// Glass material identifier of your watch.
        /// </summary>
        /// <value>
        /// Glass material id
        /// </value>
        public int GlassMaterialId { get; set; }
        public string? GlassMaterialName { get; set; }
    }
}
