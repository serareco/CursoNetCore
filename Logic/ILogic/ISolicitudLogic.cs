using Entities.Items;


namespace Logic.ILogic
{
    public interface ISolicitudLogic
    {
        int InsertSolicitud(SolicitudItem solicitudItem);
        List<Entities.Items.SolicitudItem> GetAllSolicitudes();
        SolicitudItem? GetSolicitud(int id);
        int UpdateSolicitud(SolicitudItem updSolicitud);
        int DeleteSolicitud(int id);
    }
}
