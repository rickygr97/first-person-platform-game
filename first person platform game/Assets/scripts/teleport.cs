using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    //ui is voor om op e te drukken. objecttoteleport is voor hetgene wat je wil teleporten hoeft niet alleen de player te zijn . teleportlocation is gewoon de teleportlocation . 

    public GameObject ui;
    public GameObject objecttoteleport;
    public Transform teleportlocation;

	void Start ()
    {
        ui.SetActive(false);
	}

    void OnTriggerStay(Collider other)
    {
        ui.SetActive(true);
        if((other.gameObject.tag == "Player") && Input.GetKeyDown(KeyCode.E))
        {
            objecttoteleport.transform.position = teleportlocation.transform.position;
        }
    }

    void OnTriggerExit(Collider other)
    {
        ui.SetActive(false);
    }


}
