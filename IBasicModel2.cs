using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Simple.Models
{
    public interface IBasicModel2<T>
        where T : class
    {

        void Add();

        bool Update();

        T Get();

        bool Delete();

    }
}
