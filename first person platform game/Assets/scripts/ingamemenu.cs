using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ingamemenu : MonoBehaviour {

    public GameObject button1;

    private void Start()
    {
        button1.SetActive(false);

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            button1.SetActive(true);

        }
    }
}
