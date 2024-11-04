using Res.ScriptableObjectResorce;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Res.Vive
{
    public class ResourceButton : MonoBehaviour
    {
        [SerializeField] private ObjectsType objectsType;
        [SerializeField] private Image resIcon;
        [SerializeField] private ResourceMechanic _resourceMechanic;
        [SerializeField] private Button Button;
        private bool isChanges = false;
        private void Start()
        {
            Button = GetComponent<Button>();
            RecourcViewService.instance.SetDisableIcon(resIcon, objectsType);
        }
        private void Update()
        {
            if (isChanges != _resourceMechanic.isbuttonActive)
            {
                Button.interactable = _resourceMechanic.isbuttonActive;
                isChanges = _resourceMechanic.isbuttonActive;
                if (_resourceMechanic.isbuttonActive)
                {
                    RecourcViewService.instance.SetEnebleIcon(resIcon, objectsType);
                }
                else
                {
                    RecourcViewService.instance.SetDisableIcon(resIcon, objectsType);
                }
            }
        }
    }
}

