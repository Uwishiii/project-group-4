using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantGrowth : MonoBehaviour
{
    //just putting the seeds and letting them grow with a timer
    private int currentProgress = 0;
    public int timeBetweenGrowth;
    public int maxGrowth;

    public void growth()
    {
        if (currentProgress != maxGrowth)
        {
            gameObject.transform.GetChild(currentProgress).gameObject.SetActive(true);
        }

        if (currentProgress > 0 && currentProgress < maxGrowth)
        {
            gameObject.transform.GetChild(currentProgress-1).gameObject.SetActive(false);
        }

        if (currentProgress < maxGrowth)
        {
            currentProgress++;
        }
    }

    private void OnMouseDown()
    {
        InvokeRepeating("growth",timeBetweenGrowth,timeBetweenGrowth);
    }
}
