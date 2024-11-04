using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimerBar 
{
    private Image image;
    public TimerBar(Image image)
    {
        this.image = image;
    }
    public void BarUp(float time)
    {
        image.fillAmount += 1 / time * Time.deltaTime;
    }
    public void BarDown(float time)
    {
        image.fillAmount -= 1 / time * Time.deltaTime;
    }
    public void reset()
    {

        image.fillAmount = 0;

    }
}
