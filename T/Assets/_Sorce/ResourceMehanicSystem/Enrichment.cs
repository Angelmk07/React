using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enrichment 
{
    public void StartEnrichment(ref float timeEnrichment, out bool isEnrichment)
    {
        timeEnrichment -= Time.deltaTime;
        if (timeEnrichment <= 0)
        {
            isEnrichment = false;
            return;
        }
        isEnrichment = true;
    }
}
