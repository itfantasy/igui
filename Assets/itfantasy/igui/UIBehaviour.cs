using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace itfantasy.igui
{
    public class UIBehaviour : MonoBehaviour, IUI
    {
        public MonoBehaviour mono
        {
            get
            {
                return this as MonoBehaviour;
            }
        }

        void Awake()
        {
            this.OnInitUI();
        }

        protected virtual void OnInitUI()
        {

        }
    }
}
