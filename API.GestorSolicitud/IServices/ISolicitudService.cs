using Entities.Items;
using Entities.RequestModels;

namespace API.GestorSolicitud.IServices
{
    public interface ISolicitudService
    {
        int RegisterNewSolicitud(NewSolicitudRequest newSolicitudRequest);
        int UpdateSolicitud(UpdSolicitudRequest updSolicitudRequest);
        int DeleteSolicitud(DelSolicitudRequest delSolicitudRequest);
        List<SolicitudItem> GetAllSolicitudes();
        SolicitudItem? GetSolicitud(GetSolicitudRequest getSolicitudRequest);
    }
}
