using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using itfantasy.igui;

using USlider = UnityEngine.UI.Slider;

namespace itfantasy.igui.u
{
    public class Slider : UIBehaviour, ISlider
    {
        USlider _slider;

        protected override void OnInitUI()
        {
            _slider = this.GetComponent<USlider>();
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
