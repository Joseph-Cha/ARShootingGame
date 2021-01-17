using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible_touch : MonoBehaviour {

    public GameObject brokenVariant;
    public GameObject particle;


    public void OnMouseDown()
    {
        GameObject brokenObject = Instantiate(brokenVariant, transform.position, transform.rotation) as GameObject;
        brokenObject.transform.localScale = gameObject.transform.localScale;
        Instantiate(particle, transform.position, transform.rotation);
        Destroy(gameObject);        
    }

   
}
