using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remover : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "brokenceramic" || other.tag == "ceramicware")
        {
            Destroy(other.gameObject);
        }
    }

}
