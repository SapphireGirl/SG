using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SG.Util
{
    public interface IGenericPersistable<T>
    {
        T Read(string id);
        bool Save(T obj);
        bool HasChanges { get; set; }
    }
}
