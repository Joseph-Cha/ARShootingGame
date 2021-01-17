using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FireButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public bool isBtnDown = false;

    Gun gun;

    void Awake()
    {
        isBtnDown = false;
        gun = GameObject.Find("Pistol").GetComponent<Gun>();
    }

    private void Update()
    {
        if (isBtnDown)
        {
            gun.Fire();
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