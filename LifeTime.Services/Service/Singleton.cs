using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeTime.Services.IService;

namespace LifeTime.Services.Service
{

    public class Singleton : ISingleton
    {
        private Guid _guId;
        public Singleton()
        {
            _guId = Guid.NewGuid();
        }
        public string GetGuId()
        {
            return _guId.ToString();
        }
    }
}
