using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class final : MonoBehaviour {

    public GameObject boxs;




  

    void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("Player"))
        {
            color colorscript = boxs.GetComponent<color>();
            colorscript.bools = true;

        }
    }

}
