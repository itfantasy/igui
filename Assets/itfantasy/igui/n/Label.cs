using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using itfantasy.igui;

namespace itfantasy.igui.n
{
    public class Label : UIBehaviour, ILabel
    {
        UILabel _label;

        protected override void OnInitUI()
        {
            _label = this.GetComponent<UILabel>();
        }

        public string text
        {
            get
            {
                return _label.text;
            }
            set
            {
                _label.text = value;
            }
        }
    }
}
