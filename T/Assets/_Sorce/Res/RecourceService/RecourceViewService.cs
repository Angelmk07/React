using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Res.ScriptableObjectResorce
{
    public class RecourcViewService
    {
        private static RecourcViewService Instance;
        public static RecourcViewService instance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new RecourcViewService();
                }
                return Instance;
            }
        }
        private ResourceViewData _view;
        public ResourceViewData View
        {
            get
            {

                if (_view == null)
                {
                    _view = Resources.Load("ResViewDataSo") as ResourceViewData;
                }
                return _view;
            }
        }
        public void SetEnebleIcon(Image resIcon, ObjectsType resType)
        {
            if (View.TryGetEnableIcon(resType, out Sprite icon))
            {
                resIcon.sprite = icon;
            }
        }
        public void SetDisableIcon(Image resIcon, ObjectsType resType)
        {
            if (View.TryGetDisableIcon(resType, out Sprite icon))
            {
                resIcon.sprite = icon;
            }
            else
            {
                resIcon.sprite = null;
                Debug.Log("null");
            }
        }
    }

}
