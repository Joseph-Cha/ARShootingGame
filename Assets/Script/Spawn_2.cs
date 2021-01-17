using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_2 : MonoBehaviour
{
    public GameObject[] balloons; //prefabs 갯수

    private float time;

    // Start is called before the first frame update
    void Start()
    {
        time = 0f;
        StartCoroutine(StrartSpawning_3(1));
    }

    //IEnumerator 리턴 타입을 가진다. 
    //yield return new WaitForSeconds(4)은 4초후에 하단 함수를 실행

    IEnumerator StrartSpawning_3(int index)
    {
        yield return new WaitForSeconds(index);

        //Instantiate(balloons[Random.Range(0,balloons.Length)], transform.position, transform.rotation); //  Quaternion.identity 회전 x          

        if (time <= 30f)
        {
            Instantiate(balloons[Random.Range(0, balloons.Length)], transform.position, transform.rotation);
            StartCoroutine(StrartSpawning_3(3));
        }

        else if (time <= 50f)
        {
            StartCoroutine(StrartSpawning_2(1));
        }
        /*else if (time <= 60f)
        {
            StartCoroutine(StrartSpawning_1(3));
        }
        else
        {
            StartCoroutine(StrartSpawning_0(3));
        }*/     
    }

    IEnumerator StrartSpawning_2(int index)
    {
        yield return new WaitForSeconds(index);

        if (time <= 50f)
        {
            Instantiate(balloons[Random.Range(0, balloons.Length)], transform.position, transform.rotation); //  Quaternion.identity 회전 x  
            Instantiate(balloons[Random.Range(0, balloons.Length)], transform.position, transform.rotation); //  Quaternion.identity 회전 x 
            StartCoroutine(StrartSpawning_2(2));
        }
        else if (time <= 100f)
        {
            StartCoroutine(StrartSpawning_1(1));
        }
        /*else
        {
            StartCoroutine(StrartSpawning_0(2));
        }*/
         

        //StartCoroutine(StrartSpawning_2(2));
    }
    IEnumerator StrartSpawning_1(int index)
    {
        yield return new WaitForSeconds(index);
        if (time <= 100f)
        {
            Instantiate(balloons[Random.Range(0, balloons.Length)], transform.position, transform.rotation); //  Quaternion.identity 회전 x  
            Instantiate(balloons[Random.Range(0, balloons.Length)], transform.position, transform.rotation); //  Quaternion.identity 회전 x  
            Instantiate(balloons[Random.Range(0, balloons.Length)], transform.position, transform.rotation); //  Quaternion.identity 회전 x 
            StartCoroutine(StrartSpawning_1(1));
        }
        else
        {
            StartCoroutine(StrartSpawning_0(1));
        }

       


        //StartCoroutine(StrartSpawning_1(1));
    }
    IEnumerator StrartSpawning_0(float index)
    {
        yield return new WaitForSeconds(index);

        Instantiate(balloons[Random.Range(0, balloons.Length)], transform.position, transform.rotation); //  Quaternion.identity 회전 x  
        Instantiate(balloons[Random.Range(0, balloons.Length)], transform.position, transform.rotation); //  Quaternion.identity 회전 x  
        Instantiate(balloons[Random.Range(0, balloons.Length)], transform.position, transform.rotation); //  Quaternion.identity 회전 x 
        Instantiate(balloons[Random.Range(0, balloons.Length)], transform.position, transform.rotation); //  Quaternion.identity 회전 x 

        StartCoroutine(StrartSpawning_0(0.5f));

        //StartCoroutine(StrartSpawning_0(0.5f));
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
    }
}
