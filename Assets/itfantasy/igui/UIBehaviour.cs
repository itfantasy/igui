using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

namespace itfantasy.igui
{
    public class UIBehaviour : MonoBehaviour, IUI
    {
        RectTransform _rTrans;
        UIWidget _uiWidget;

        UIType _uiType;

        public UIType uiType
        {
            get { return this._uiType; }
        }

        public float x
        {
            get
            {
                return this.transform.position.x;
            }
            set
            {
                this.transform.position = new Vector3(value, this.transform.position.y, this.transform.position.z);
            }
        }

        public float y
        {
            get
            {
                return this.transform.position.y;
            }
            set
            {
                this.transform.position = new Vector3(this.transform.position.x, value, this.transform.position.z);
            }
        }

        public float z
        {
            get
            {
                return this.transform.position.z;
            }
            set
            {
                this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, value);
            }
        }

        public float width
        {
            get
            {
                if (this._rTrans != null)
                {
                    return this._rTrans.sizeDelta.x;
                }
                else
                {
                    return (float)this._uiWidget.width;
                }
            }
            set
            {
                if (this._rTrans != null)
                {
                    this._rTrans.sizeDelta = new Vector2(value, this._rTrans.sizeDelta.y);
                }
                else
                {
                    this._uiWidget.width = (int)value;
                }
            }
        }

        public float height
        {
            get
            {
                if (this._rTrans != null)
                {
                    return this._rTrans.sizeDelta.y;
                }
                else
                {
                    return (float)this._uiWidget.height;
                }
            }
            set
            {
                if (this._rTrans != null)
                {
                    this._rTrans.sizeDelta = new Vector2(this._rTrans.sizeDelta.x, value);
                }
                else
                {
                    this._uiWidget.height = (int)value;
                }
            }
        }

        public float scaleX
        {
            get
            {
                return this.transform.localScale.x;
            }
            set
            {
                this.transform.localScale = new Vector3(value, this.transform.localScale.y, this.transform.localScale.z);
            }
        }

        public float scaleY
        {
            get
            {
                return this.transform.localScale.y;
            }
            set
            {
                this.transform.localScale = new Vector3(this.transform.localScale.x, value, this.transform.localScale.z);
            }
        }

        public float scaleZ
        {
            get
            {
                return this.transform.localScale.z;
            }
            set
            {
                this.transform.localScale = new Vector3(this.transform.localScale.x, this.transform.localScale.y, value);
            }
        }

        public float rotationX
        {
            get
            {
                return this.transform.localRotation.x;
            }
            set
            {
                this.transform.localRotation = new Quaternion(value, this.transform.localRotation.y, this.transform.localRotation.z, this.transform.localRotation.w);
            }
        }

        public float rotationY
        {
            get
            {
                return this.transform.localRotation.y;
            }
            set
            {
                this.transform.localRotation = new Quaternion(this.transform.localRotation.x, value, this.transform.localRotation.z, this.transform.localRotation.w);
            }
        }

        public float rotationZ
        {
            get
            {
                return this.transform.localRotation.z;
            }
            set
            {
                this.transform.localRotation = new Quaternion(this.transform.localRotation.x, this.transform.localRotation.y, value, this.transform.localRotation.w);
            }
        }

        public MonoBehaviour mono
        {
            get
            {
                return this as MonoBehaviour;
            }
        }

        void Awake()
        {
            this._rTrans = this.GetComponent<RectTransform>();
            if (this._rTrans != null)
            {
                this._uiType = UIType.UGUI;
            }
            else
            {
                this._uiType = UIType.NGUI;
                this._uiWidget = this.GetComponent<UIWidget>();
            }

            this.OnInitUI();
        }

        public virtual void SetClick(System.Action<GameObject> onClick)
        {
            //UIClickListener.Get(this.gameObject).onClick = onClick;

            switch(this._uiType)
            {
                case UIType.UGUI:
                    EventTriggerListener.Get(this.gameObject).onClick = (go) =>
                    {
                        onClick.Invoke(go);
                    };
                    break;
                case UIType.NGUI:
                    UIEventListener.Get(this.gameObject).onClick = (go) =>
                    {
                        onClick.Invoke(go);
                    };
                    break;
            }
        }

        protected virtual void OnInitUI()
        {

        }

        
    }
}
