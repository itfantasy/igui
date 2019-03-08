using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using itfantasy.igui;

namespace itfantasy.igui.n
{
    public class Input : UIBehaviour, IInput
    {
        UIInput _input;

        protected override void OnInitUI()
        {
            _input = this.GetComponent<UIInput>();
        }

        public string text
        {
            get
            {
                return _input.value;
            }
            set
            {
                _input.value = value;
            }
        }
    }
}
