using System.Web;

namespace Dominio.Models.dto
{
    public class PhotoDto
    {
        public HttpPostedFileBase Photo { get; set; }
        public string Title { get; set; }
    }
}
