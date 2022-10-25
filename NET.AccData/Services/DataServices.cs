using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.AccData.Services
{
    internal class DataServices
    {
        private readonly MyDataContext _myDataContext;
        public DataServices()
        {
            //_myDataContext = new MyDataContext(DbContextOptions);
        }
    }
}
