using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace itfantasy.igui
{
    public interface IUI
    {
        UIType uiType { get; }

        float x { get; set; }

        float y { get; set; }

        float z { get; set; }

        float width { get; set; }

        float height { get; set; }

        float scaleX { get; set; }

        float scaleY { get; set; }

        float scaleZ { get; set; }

        float rotationX { get; set; }

        float rotationY { get; set; }

        float rotationZ { get; set; }

        MonoBehaviour mono { get; }


    }
}
