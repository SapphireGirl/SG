using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SG.Util
{
    public interface IView
    {
         IViewModel ViewModel { get; set; }
    }
}
