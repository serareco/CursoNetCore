using API.GestorSolicitud.IServices;
using Entities.Items;
using Entities.RequestModels;
using Microsoft.AspNetCore.Mvc;

namespace API.GestorSolicitud.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class SolicitudController : ControllerBase
    {
        private readonly ISolicitudService _solicitudService;
        public SolicitudController(ISolicitudService SolicitudService)
        {
            _solicitudService = SolicitudService;
        }

        [HttpPost(Name = "InsertSolicitud")]
        public int InsertSolicitud(NewSolicitudRequest newSolicitudRequest)
        {
            return _solicitudService.RegisterNewSolicitud(newSolicitudRequest);
        }
        [HttpPut(Name = "UpdateSolicitud")]
        public int UpdateSolicitud(UpdSolicitudRequest updSolicitudRequest)
        {
            return _solicitudService.UpdateSolicitud(updSolicitudRequest);
        }
        [HttpDelete(Name = "DeleteSolicitud")]
        public int DeleteSolicitud([FromQuery]DelSolicitudRequest delSolicitudRequest)
        {
            return _solicitudService.DeleteSolicitud(delSolicitudRequest);
        }
        [HttpGet(Name = "GetAllSolicitudes")]
        public List<SolicitudItem> GetAllSolicitudes()
        {
            return _solicitudService.GetAllSolicitudes();
        }
        [HttpGet(Name = "GetSolicitud")]
        public SolicitudItem? GetSolicitud([FromQuery]GetSolicitudRequest getSolicitudRequest)
        {
           // GetSolicitudRequest getSolicitudRequest = new GetSolicitudRequest();
           // getSolicitudRequest.Id = pid;
            return _solicitudService.GetSolicitud(getSolicitudRequest);
            //return _solicitudService.GetAllSolicitudes();
        }
    }
}
