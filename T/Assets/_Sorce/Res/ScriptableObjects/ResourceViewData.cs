using Res.ParametrsScriptObj;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Res.ScriptableObjectResorce
{
    [CreateAssetMenu(fileName = "ResViewDataSo", menuName = "so/ new resource")]
    public class ResourceViewData : ScriptableObject
    {
        [SerializeField] private List<ResourceView> ResourceViews;
        public bool TryGetEnableIcon(ObjectsType objectsTipe, out Sprite icon)
        {
            icon = null;
            foreach (var data in ResourceViews)
            {
                if (data.ObjectsTipe == objectsTipe)
                {
                    icon = data.Enable;
                    return true;
                }
            }
            return false;
        }
        public bool TryGetDisableIcon(ObjectsType objectsTipe, out Sprite icon)
        {
            icon = null;
            foreach (var data in ResourceViews)
            {
                if (data.ObjectsTipe == objectsTipe)
                {
                    icon = data.Dizable;
                    return true;
                }
            }
            return false;
        }
    }

}
