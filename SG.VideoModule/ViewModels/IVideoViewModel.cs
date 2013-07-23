using System;
using SG.Util;

namespace SG.VideoModule.ViewModels
{
    public interface IVideoViewModel : IViewModel
    {
        Uri VideoUri { get; set; }
    }
}
