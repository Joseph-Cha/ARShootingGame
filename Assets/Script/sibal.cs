using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class sibal : MonoBehaviour
{
    Rigidbody Rigidbody;
    private int x = 100, y = 100, z = 100;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
        Rigidbody.AddForce(Random.Range(-x,x), Random.Range(-y, y), Random.Range(-z, z));
    }
}
