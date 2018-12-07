using UnityEngine;
using UnityEngine.EventSystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace itfantasy.igui
{
    public class UIEffectBehaviour : MonoBehaviour, IPointerClickHandler
    {
        void Awake()
        {
            this.OnAuto(DealAuto);
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            this.OnClick();
        }

        private void DealAuto(int mod)
        {
            if (mod > 0)
            {
                this.OnAuto(DealAuto);
            }
            else if (mod < 0)
            {
                Destroy(this);
            }
        }

        protected virtual void OnAuto(Action<int> callback)
        {
            
        }

        protected virtual void OnClick()
        {
            
        }

        protected virtual void OnTrigger(object token)
        {
            
        }

        public void Trigger(object token)
        {
            this.OnTrigger(token);
        }
    }
}
