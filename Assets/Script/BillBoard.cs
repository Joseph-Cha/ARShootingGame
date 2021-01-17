using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillBoard : MonoBehaviour
{
    public Transform cam;
    public GameObject Score;
    private float time;

    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("AR Camera").transform;
        time = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(transform.position + cam.rotation * Vector3.forward, cam.rotation * Vector3.up);
        time += Time.deltaTime;
        if (time > 1.5f)
        {
            gameObject.SetActive(false);
        }
    }
}
