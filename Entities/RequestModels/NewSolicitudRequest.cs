using Entities.Items;

namespace Entities.RequestModels
{
    public class NewSolicitudRequest
    {
        public DateTime? FechaSolcitud { get; set; }
        public string? Estado { get; set; }
        public SolicitudItem ToSolicitudItem()
        { 
            var solicitudItem = new SolicitudItem();
            solicitudItem.FechaSolcitud = FechaSolcitud;
            solicitudItem.Estado = Estado;
            
            return solicitudItem;

        }
    }
}
