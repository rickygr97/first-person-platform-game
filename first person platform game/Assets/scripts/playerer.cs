using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerer : MonoBehaviour
{

    public GameObject objecttoteleport;
    public Transform teleportlocation;

    public GameObject enemy;
    private int _health = 4;
    public int health
    {
        get
        {
            return _health;

        }

        set
        {
            _health = value;
            Debug.Log("health schanged" + value);
            if (health <= 0)
            {
                die();
            }

        }
    }

    void Start()
    {

    }


    void die()
    {
        Debug.Log("player died.");
       objecttoteleport.transform.position = teleportlocation.transform.position;
        health = 4;
    }
}
