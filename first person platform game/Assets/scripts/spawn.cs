using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject playerspawn;
    public GameObject lights;

    void OnTriggerEnter (Collider other)
    {
		if (other.gameObject.CompareTag("Player"))
        {
            lights.SetActive(true);
        }
	}
    void Start()
    {
        lights.SetActive(true);
    }
}
