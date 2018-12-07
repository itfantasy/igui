using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using itfantasy.igui;

namespace itfantasy.igui.n
{
    public class Button : UIBehaviour, IButton
    {
        UIButton _button;
        BoxCollider _boxCollider;
        UILabel _label;

        Component[] components;

        protected override void OnInitUI()
        {
            _button = this.GetComponent<UIButton>();
            _label = this.GetComponentInChildren<UILabel>();
            _boxCollider = this.GetComponent<BoxCollider>();
            base.OnInitUI();
        }

        public bool enable
        {
            get
            {
                return _button.isEnabled;
            }
            set
            {
                _button.isEnabled = value;
                _boxCollider.enabled = value;
            }
        }

        public string text
        {
            get
            {
                return _label != null ? _label.text : "";
            }
            set
            {
                if (_label != null) _label.text = value;
            }
        }

    }
}
