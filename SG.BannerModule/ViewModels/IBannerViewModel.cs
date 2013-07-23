using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SG.Util;

namespace SG.BannerModule.ViewModels
{
    public interface IBannerViewModel : IViewModel
    {
        Uri BannerImageUri { get; set; }
    }
}
