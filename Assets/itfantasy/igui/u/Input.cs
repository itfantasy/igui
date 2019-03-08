using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using itfantasy.igui;

namespace itfantasy.igui.u
{
    public class Input : UIBehaviour, IInput
    {
        InputField _input;

        protected override void OnInitUI()
        {
            _input = this.GetComponent<InputField>();
        }

        public string text
        {
            get
            {
                return _input.text;
            }
            set
            {
                _input.text = value;
            }
        }

        
    }
}
