﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace itfantasy.igui
{
    public interface IProgressBar : IUI
    {
        float value { get; set; }
    }
}
