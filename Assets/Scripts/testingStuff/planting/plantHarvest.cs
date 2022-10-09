using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantHarvest : MonoBehaviour
{
    [SerializeField] private GameObject plantList;
    [SerializeField] private GameObject[] stages;

    private void OnMouseDown()//harvesting by deleting all stages set in the soil
    {
        if (this.name == "stage3")
        {
            foreach (var i in (stages))
            {
                Destroy(i);
            }
        }
        
        //adding the plant to list(inventory)
    }
}
