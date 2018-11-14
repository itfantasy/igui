using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using itfantasy.igui;

public interface IImage : IUI {

    Texture texture { get; set; }

    float alpha { get; set; }
}
