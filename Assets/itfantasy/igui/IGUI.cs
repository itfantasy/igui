using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

namespace itfantasy.igui
{
    public class IGUI
    {
        public static UIType uiType { get; set; }

        public static T Get<T>(GameObject go) where T : Component
        {
            T mono = go.GetComponent<T>();
            if(mono == null)
            {
                mono = go.AddComponent<T>();
            }
            return mono;
        }

        public static Component Get(GameObject go, Type type)
        {
            Component mono = go.GetComponent(type);
            if (mono == null)
            {
                mono = go.AddComponent(type);
            }
            return mono;
        }

        public static bool Has<T>(GameObject go) where T : Component
        {
            T mono = go.GetComponent<T>();
            return mono != null;
        }

        public static bool Has(GameObject go, Type type)
        {
            Component mono = go.GetComponent(type);
            return mono != null;
        }

        private static I UI<I, U, N>(GameObject go, UIType type = UIType.NONE)
            where I : IUI
            where U : UIBehaviour, I
            where N : UIBehaviour, I
        {
            switch (type)
            {
                case UIType.UGUI:
                    return (I)Get<U>(go);
                case UIType.NGUI:
                    return (I)Get<N>(go);
                default:
                    if (Has<U>(go))
                    {
                        return (I)Get<U>(go);
                    }
                    else if (Has<N>(go))
                    {
                        return (I)Get<N>(go);
                    }
                    else
                    {
                        UIType the = theType(type);
                        if (the != UIType.NONE)
                        {
                            return UI<I, U, N>(go, the);
                        }
                        else
                        {
                            return default(I);
                        }
                    }
            }
        }

        private static IUI ComponentToUI(Component mono)
        {
            return (mono as UIBehaviour) as IUI;
        }

        private static IUI UI(GameObject go, Type uType, Type nType, UIType type = UIType.NONE)
        {
            switch (type)
            {
                case UIType.UGUI:
                    return ComponentToUI(Get(go, uType));
                case UIType.NGUI:
                    return ComponentToUI(Get(go, nType));
                default:
                    if (Has(go, uType))
                    {
                        return ComponentToUI(Get(go, uType));
                    }
                    else if (Has(go, nType))
                    {
                        return ComponentToUI(Get(go, nType));
                    }
                    else
                    {
                        UIType the = theType(type);
                        if (the != UIType.NONE)
                        {
                            return UI(go, uType, nType, the);
                        }
                        else
                        {
                            return null;
                        }
                    }
            }
        }

        public static IButton Button(GameObject go, UIType type = UIType.NONE)
        {
            return UI<IButton, itfantasy.igui.u.Button, itfantasy.igui.n.Button>(go, type);
        }

        public static ILabel Label(GameObject go, UIType type = UIType.NONE)
        {
            return UI<ILabel, itfantasy.igui.u.Label, itfantasy.igui.n.Label>(go, type);
        }

        public static IImage Image(GameObject go, UIType type = UIType.NONE)
        {
            return UI<IImage, itfantasy.igui.u.Image, itfantasy.igui.n.Image>(go, type);
        }

        #region custom extends ...

        private static Dictionary<Type, Type[]> _customDicts = new Dictionary<Type, Type[]>();
        
        public static void CustomExtends(Type I, Type U, Type N)
        {
            if(!_customDicts.ContainsKey(I))
            {
                _customDicts[I] = new Type[] { U, N };
            }
        }

        public static I Custom<I>(GameObject go, UIType type = UIType.NONE) where I : IUI
        {
            Type itype = typeof(I);
            if(!_customDicts.ContainsKey(itype))
            {
                return default(I);
            }
            else
            {
                Type[] types = _customDicts[itype];
                IUI ui = UI(go, types[0], types[1], type);
                return (I)ui;
            }
        }

        #endregion

        private static UIType theType(UIType type)
        {
            if (type != UIType.NONE)
            {
                return type;
            }
            return uiType;
        }

    }

    public enum UIType
    {
        NONE = 0,
        UGUI,
        NGUI
    }
}
