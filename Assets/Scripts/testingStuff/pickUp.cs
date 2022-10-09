using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUp : MonoBehaviour
{
    public Transform theDest;
    public bool ha = false;
    private int num = 0;

    //it just picks up objects and lets them go---->doesnt put them in a specific place but lets the gravity od the work
    void Update()
    {
        if (ha==true)
        {
            GetComponent<BoxCollider>().enabled = false;
            GetComponent<Rigidbody>().useGravity = false;
            GetComponent<Rigidbody>().isKinematic = false;
            this.transform.position = theDest.position;
            this.transform.parent = GameObject.Find("destination").transform;
        }else if (!ha && this.transform.parent != null){
            this.transform.parent = null;
            GetComponent<Rigidbody>().useGravity = true;
            GetComponent<BoxCollider>().enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && num > 1)
        { 
            if(this.gameObject.tag == "selectable"){
                ha = false;
                num = 0;
            }
        }else{
            num++;
        }
}


    void OnMouseDown()
    {
        if (this.gameObject.tag == "selectable")
        {
            ha = true;
            num = 1;
        }

    }
}
