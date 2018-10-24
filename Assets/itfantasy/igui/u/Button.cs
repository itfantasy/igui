using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using itfantasy.igui;

using UButton = UnityEngine.UI.Button;

namespace itfantasy.igui.u
{
    public class Button : UIBehaviour, IButton
    {
        UButton _button;
        Text _text;

        protected override void OnInitUI()
        {
            _button = this.GetComponent<UButton>();
            _text = this.GetComponentInChildren<Text>();
            base.OnInitUI();
        }

        public bool enable
        {
            get
            {
                return _button.enabled;
            }
            set
            {
                _button.enabled = value;
            }
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

        public void SetClick(Action<GameObject> onClick)
        {
            EventTriggerListener.Get(this.gameObject).onClick = (go) =>
            {
                onClick.Invoke(go);
            };
        }

    }
}
