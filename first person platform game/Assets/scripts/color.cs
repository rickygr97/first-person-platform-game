using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color : MonoBehaviour
{
    public bool bools;

    private void Start()
    {
        bools = false;

    }



    private void Update()
    {
        if (bools)
        {
            this.gameObject.GetComponent<Renderer>().material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));

        }

    }
}
