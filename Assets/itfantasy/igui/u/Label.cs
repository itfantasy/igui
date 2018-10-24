using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using itfantasy.igui;

namespace itfantasy.igui.u
{
    public class Label : UIBehaviour, ILabel
    {
        Text _text;

        protected override void OnInitUI()
        {
            _text = this.GetComponent<Text>();
            base.OnInitUI();
        }

        public string text
        {
            get
            {
                return _text.text;
            }
            set
            {
                _text.text = value;
            }
        }
    }
}
