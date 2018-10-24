using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

namespace itfantasy.igui
{
    public interface IButton : IUI
    {
        bool enable { get; set; }
        string text { get; set; }
        void SetClick(Action<GameObject> onClick);
    }
}
