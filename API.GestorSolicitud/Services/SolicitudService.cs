using API.GestorSolicitud.IServices;
using Entities.Items;
using Entities.RequestModels;
using Logic.ILogic;

namespace API.GestorSolicitud.Services
{
    public class SolicitudService : ISolicitudService
    {
        private readonly ISolicitudLogic _solicitudLogic;

        public SolicitudService(ISolicitudLogic solicitudLogic)
        {
            _solicitudLogic = solicitudLogic;
        }

        public List<SolicitudItem> GetAllSolicitudes()
        {
            return _solicitudLogic.GetAllSolicitudes();
        }
        public SolicitudItem? GetSolicitud(GetSolicitudRequest getSolicitudRequest)
        {
            return _solicitudLogic.GetSolicitud(getSolicitudRequest.Id);
        }
        public int RegisterNewSolicitud(NewSolicitudRequest newSolicitudRequest)
        {
            SolicitudItem newSolicitud = newSolicitudRequest.ToSolicitudItem();

            return _solicitudLogic.InsertSolicitud(newSolicitud);       
        }

        public int UpdateSolicitud(UpdSolicitudRequest updSolicitudRequest)
        {
            SolicitudItem newSolicitud = updSolicitudRequest.ToSolicitudItem();

            return _solicitudLogic.UpdateSolicitud(newSolicitud);
        }

        public int DeleteSolicitud(DelSolicitudRequest delSolicitudRequest)
        {
            return _solicitudLogic.DeleteSolicitud(delSolicitudRequest.Id);
        }

    }
}
