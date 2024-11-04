using Res.ScriptableObjectResorce;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Res.ResourceService
{
    public class RecourcParamService
    {
        private static RecourcParamService Instance;
        public static RecourcParamService instance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new();
                }
                return Instance;
            }
        }
        private DataSo _view;

        public DataSo View
        {
            get
            {

                if (_view == null)
                {
                    _view = Resources.Load("ResViewData") as DataSo;
                }
                return _view;
            }
        }
        public void SetEnebleTime(ref float restime, ObjectsType resType)
        {
            if (View.TryGetEnableTime(resType, out float time))
            {
                restime = time;
            }
            else
            {
                Debug.Log("nulltime");
            }
        }
        public void SetDisableTime(ref float restime, ObjectsType resType)
        {
            if (View.TryGetDisableTime(resType, out float time))
            {
                restime = time;
            }
        }
    }

}
