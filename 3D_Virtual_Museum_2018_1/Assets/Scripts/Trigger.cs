using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject btn;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            btn.SetActive(true);
        }
    }
}
