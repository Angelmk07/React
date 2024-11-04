using Res.ParametrsScriptObj;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Res.ScriptableObjectResorce
{
    [CreateAssetMenu(fileName = "ResViewData", menuName = "so/ new resource data")]
    public class DataSo : ScriptableObject
    {
        [SerializeField] private List<ResorceData> ResourceViews;
        public bool TryGetEnableTime(ObjectsType objectsTipe, out float time)
        {
            time = 0;
            foreach (var data in ResourceViews)
            {
                if (data.ObjectsTipe == objectsTipe)
                {
                    time = data.EnableTime;
                    return true;
                }
            }
            return false;
        }
        public bool TryGetDisableTime(ObjectsType objectsTipe, out float time)
        {
            time = 0;
            foreach (var data in ResourceViews)
            {
                if (data.ObjectsTipe == objectsTipe)
                {
                    time = data.DizableTime;
                    return true;
                }
            }
            return false;
        }
    }

}
