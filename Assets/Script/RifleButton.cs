using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RifleButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public bool isBtnDown = false;

    Gun gun;

    void Start()
    {
        gun = GameObject.Find("Rifle").GetComponent<Gun>();
    }

    private void Update()
    {
        if (isBtnDown)
        {
            gun.Fire();
        }

        else
        {
            gun.Idle();
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isBtnDown = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isBtnDown = false;
    }

}