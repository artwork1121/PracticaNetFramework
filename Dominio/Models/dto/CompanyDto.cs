using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dominio.Models.dto
{
    public class CompanyDto
    {
        public long Id { get; set; }
        public string CUIT { get; set; }
        public string CompanyName { get; set; }
        public bool IsDelete { get; set; } = false;
    }
}
