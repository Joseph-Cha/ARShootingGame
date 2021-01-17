using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    private Gun gun;

    public GameObject cam;
    public GameObject smoke;
    public Animator Ani;

    private void Start()
    {
        gun = GameObject.Find("Pistol").GetComponent<Gun>();
        Ani = GameObject.Find("Pistol").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*
    public void Fire()
    {
        gun.magAmmo--;
        if(gun.magAmmo <= 0)
        {
            gun.state = Gun.State.Empty;
        }

        Ani.SetTrigger("Fire");

        RaycastHit hit; //부딪힌 대상의 정보
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit))
        {
            if (hit.transform.name == "balloon1(Clone)" ||
                hit.transform.name == "balloon2(Clone)" ||
                hit.transform.name == "balloon3(Clone)"
                )
            {
                Destroy(hit.transform.gameObject);
                Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal)); //hit.normal : 부딪힌 면과 90도가 되는 값
            }
        }
        
    }
    */

}
