using Entities.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.RequestModels
{
    public class UpdSolicitudRequest
    {
        public int Id { get; set; }
        public DateTime? FechaSolcitud { get; set; }
        public string? Estado { get; set; }
        public SolicitudItem ToSolicitudItem()
        {
            var solicitudItem = new SolicitudItem();
            solicitudItem.Id = Id;
            solicitudItem.FechaSolcitud = FechaSolcitud;
            solicitudItem.Estado = Estado;

            return solicitudItem;

        }
    }
}
