using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    string animal = "양";    //문자열
    int count = 0;  //정수형
    void Start()
    {
        Debug.Log(animal + " 세기 프로그램!");
    }
    void Update()
    {
        Debug.Log(animal + (++count) + " 마리");
    }
}