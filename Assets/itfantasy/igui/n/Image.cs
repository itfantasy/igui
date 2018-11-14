using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using itfantasy.igui;

namespace itfantasy.igui.n
{
    public class Image : UIBehaviour, IImage
    {
        UITexture _uiTexture;

        public Texture texture
        {
            get
            {
                return _uiTexture.mainTexture;
            }
            set
            {
                _uiTexture.mainTexture = value;
            }
        }

        public float alpha
        {
            get
            {
                return _uiTexture.color.a;
            }
            set
            {
                _uiTexture.color = new Color(_uiTexture.color.r, _uiTexture.color.g, _uiTexture.color.b, value);
            }
        }

        protected override void OnInitUI()
        {
            _uiTexture = this.GetComponent<UITexture>();
            base.OnInitUI();
        }
    }
}
