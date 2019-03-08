using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using itfantasy.igui;

namespace itfantasy.igui.n
{
    public class ProgressBar : UIBehaviour, IProgressBar
    {
        UISlider _slider;

        protected override void OnInitUI()
        {
            _slider = this.GetComponent<UISlider>();
            base.OnInitUI();
        }

        public float value
        {
            get
            {
                return _slider.value;
            }
            set
            {
                _slider.value = value;
            }
        }
    }
}
