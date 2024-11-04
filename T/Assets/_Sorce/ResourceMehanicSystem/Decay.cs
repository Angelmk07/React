using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decay 
{
    public Action YouDead;
    public void StartDecay(ref float timeDecay, out bool isDecay)
    {
        timeDecay -= Time.deltaTime;
        if (timeDecay < 0)
        {
            isDecay = false;
            YouDead?.Invoke();
            return;
        }
        isDecay = true;
    }
}
 