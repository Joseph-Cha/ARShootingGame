using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    public float switchDelay = 1f;
    public GameObject[] weapons;

    private int index = 0;
    private bool isSwithching = false;


    // Start is called before the first frame update
    private void Start()
    {
        initializeWeapon();
    }

    // Update is called once per frame
    private void Update()
    {

    }

    public void SwithchingWeaponstoRifle()
    {
        StartCoroutine(SwithchDelay());
        if(isSwithching)
        {
            weapons[0].SetActive(false);
            weapons[1].SetActive(true);
        }
    }
    public void SwithchingWeaponstoHandGun()
    {
        StartCoroutine(SwithchDelay());
        if (isSwithching)
        {
            weapons[1].SetActive(false);
            weapons[0].SetActive(true);
        }
    }

    private void initializeWeapon()
    {
        for(int i = 0; i< weapons.Length; i++)
        {
            weapons[i].SetActive(false);
        }
        weapons[0].SetActive(true);
        index = 0;
    }

    public IEnumerator SwithchDelay()
    {
        isSwithching = true;
        yield return new WaitForSeconds(switchDelay);
        isSwithching = false;
    }
}

