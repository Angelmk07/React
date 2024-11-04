using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Res.ParametrsScriptObj
{
    [Serializable]
    public class ResorceData
    {
        [field: SerializeField]
        public ObjectsType ObjectsTipe { get; private set; }
        [field: SerializeField]
        public float EnableTime { get; private set; }
        [field: SerializeField]
        public float DizableTime { get; private set; }
    }
}

