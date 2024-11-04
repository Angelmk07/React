using System;
using UnityEngine;
namespace Res.ParametrsScriptObj
{
    [Serializable]
    public class ResourceView
    {
        [field: SerializeField]
        public ObjectsType ObjectsTipe { get; private set; }
        [field: SerializeField]
        public Sprite Enable { get; private set; }
        [field: SerializeField]
        public Sprite Dizable { get; private set; }
    }

}
