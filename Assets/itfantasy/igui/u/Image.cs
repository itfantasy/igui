using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using itfantasy.igui;

namespace itfantasy.igui.u
{
    public class Image : UIBehaviour, IImage
    {
        RawImage _rawImage;

        public Texture texture
        {
            get
            {
                return _rawImage.texture;
            }
            set
            {
                _rawImage.texture = value;
            }
        }

        public float alpha
        {
            get
            {
                return _rawImage.color.a;
            }
            set
            {
                _rawImage.color = new Color(_rawImage.color.r, _rawImage.color.g, _rawImage.color.b, value);
            }
        }

        protected override void OnInitUI()
        {
            _rawImage = this.GetComponent<RawImage>();
            base.OnInitUI();
        }
    }
}
