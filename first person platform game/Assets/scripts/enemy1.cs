using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1 : MonoBehaviour
{

    public GameObject player;

    void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("Player"))
        {
            playerer playerscript = player.GetComponent<playerer>();
            playerscript.health -= 4;
        }
    }
}
