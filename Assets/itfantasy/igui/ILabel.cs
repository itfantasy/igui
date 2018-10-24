using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace itfantasy.igui
{
    public interface ILabel : IUI
    {
        string text { get; set; }
    }
}
