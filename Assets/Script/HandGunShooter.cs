using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class HandGunShooter : MonoBehaviour
{
    public Gun gun;

    private void Start()
    {
        if(gun != null)
        {
            return;
        }

        gun = GameObject.Find("Pistol").GetComponent<Gun>();
        
    }

    private void OnEnable()
    {
        
    }

    private void Update()
    {
        UpdateUI();
    }
    
    private void UpdateUI()
    {
        if (gun != null && UIManager.instance != null)
        {
            UIManager.instance.H_UpdateAmmoText(gun.magAmmo, gun.ammoRemain);
        }
    }

    private void OnAnimatorIK(int layerIndex)
    {
        
    }

}
