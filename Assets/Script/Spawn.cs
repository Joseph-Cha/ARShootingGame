using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public Transform[] spawnPoints; // 생성 위치
    public GameObject[] balloons; //prefabs 갯수

    // Start is called before the first frame update
    void Start()
    {
        //IEnumerator의 특성상 n초 후에 프로그램이 실행이 되는데 n초 동안 프로그램이 멈추기 때문에 
        //StartCoroutine을 이용해서 프로그램이 진행되는 것과 동시에 함수를 실행
        StartCoroutine(StrartSpawning(1)); 
    }

    //IEnumerator 리턴 타입을 가진다. 
    //yield return new WaitForSeconds(4)은 4초후에 하단 함수를 실행
    IEnumerator StrartSpawning(int index)
    {
        yield return new WaitForSeconds(index);
        for(int i = 0; i <3; i++)
        {
            Instantiate(balloons[i], spawnPoints[i].position, Quaternion.identity); //  Quaternion.identity 회전 x
        }
        StartCoroutine(StrartSpawning(4));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
