using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public GameObject[] prefabs;
    private int i;

    // Update is called once per frame
    void Update()
    {
        for (i = 0; i < prefabs.Length; i++)
        {
            Instantiate(prefabs[i], transform.position, transform.rotation.normalized);
        }
    }
    
}
