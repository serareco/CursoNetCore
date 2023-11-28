using Entities.Items;
using Data;
using Logic.ILogic;

namespace Logic.Logic
{
    public class SolicitudLogic : ISolicitudLogic
    {
        private readonly ServiceContext _serviceContext;
        public SolicitudLogic(ServiceContext serviceContext)
        {
            _serviceContext = serviceContext;
        }

        public int UpdateSolicitud(SolicitudItem newSolicitud)
        {

            _serviceContext.Solicitudes.Update(newSolicitud);
            _serviceContext.SaveChanges();
            return newSolicitud.Id;
        }

        public List<SolicitudItem> GetAllSolicitudes()
        {
            return _serviceContext.Solicitudes.ToList();
        }

        public int InsertSolicitud(SolicitudItem solicitudItem)
        {
            _serviceContext.Solicitudes.Add(solicitudItem);
            _serviceContext.SaveChanges();
            return solicitudItem.Id;
        }
        public int DeleteSolicitud(int id)
        {
            SolicitudItem? newSolicitud = _serviceContext.Solicitudes.Find(id);
            int _return = id;
            if (newSolicitud != null)
            {
                _serviceContext.Solicitudes.Remove(newSolicitud);
                _serviceContext.SaveChanges();
            }
            else {
                _return = -1;
            }

            return _return;
        }
        public SolicitudItem? GetSolicitud(int id)
        {
            SolicitudItem? newSolicitud = _serviceContext.Solicitudes.Find(id);
            return newSolicitud;
        }
    }
}
