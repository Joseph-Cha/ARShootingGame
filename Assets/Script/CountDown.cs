using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    float currentTime = 0f;
    float stratingTime = 5f;

    public Text countDownText;
    public Text StartText;

    public GameObject[] GunGame;
    

    private void Start()
    {
        currentTime = stratingTime;
        
    }

    private void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countDownText.text = currentTime.ToString("0");
        if (currentTime <= 0)
        {
            countDownText.enabled = false;
            StartText.enabled = true;
        }
        if (currentTime < -1.5)
        {
            StartText.enabled = false;
            for (int i = 0; i < GunGame.Length; i++)
            {
                GunGame[i].gameObject.SetActive(true);
            }
        }



    }

}
