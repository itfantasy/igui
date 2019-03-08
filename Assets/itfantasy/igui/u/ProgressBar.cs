using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using itfantasy.igui;

using UImage = UnityEngine.UI.Image;

namespace itfantasy.igui.u
{
    public class ProgressBar : UIBehaviour, IProgressBar
    {
        UImage _image;

        protected override void OnInitUI()
        {
            _image = this.transform.Find("Foreground").GetComponent<UImage>();
            base.OnInitUI();
        }

        public float value
        {
            get
            {
                return _image.fillAmount;
            }
            set
            {
                _image.fillAmount = value;
            }
        }
    }
}
