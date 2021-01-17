using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class RifleShooter : MonoBehaviour
{
    public Gun gun;

    private void Start()
    {
        gun = GameObject.Find("Rifle").GetComponent<Gun>();
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
            UIManager.instance.R_UpdateAmmoText(gun.magAmmo, gun.ammoRemain);
        }
    }

    private void OnAnimatorIK(int layerIndex)
    {
        
    }

}
