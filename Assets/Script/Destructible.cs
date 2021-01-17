using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour {

    public GameObject brokenVariant;
    public GameObject particle;


    public void Broken()
    {
        GameObject brokenObject = Instantiate(brokenVariant, transform.position, transform.rotation) as GameObject;
        brokenObject.transform.localScale = gameObject.transform.localScale;
        Instantiate(particle, transform.position, transform.rotation);
        Destroy(gameObject);        
    }

   
}
