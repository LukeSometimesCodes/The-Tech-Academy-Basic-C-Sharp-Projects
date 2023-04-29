using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Challenge
{
    public class DbContext : IDisposable, System.Data.Entity.Infrastructure.IObjectContextAdapter
    {
        public ObjectContext ObjectContext => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
