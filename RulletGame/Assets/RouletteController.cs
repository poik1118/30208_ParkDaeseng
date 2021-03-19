using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0; //룰렛을 돌리기위한 회전속도지정

    void Update()
    {
        if (Input.GetMouseButtonDown(0))    //룰렛을 10만큼 회전
        {
            this.rotSpeed = 10.0f;
        }      
        if (Input.GetMouseButtonDown(2))    //룰렛을 -10만큼 회전
        {
            this.rotSpeed = -10.0f;
        }
        if (Input.GetMouseButtonDown(1))    //룰렛을 정지시킨다
        {
            rotSpeed = 0.0f;
        }
        this.rotSpeed *= 0.987f;

        transform.Rotate(0, 0, this.rotSpeed);
    }
}
