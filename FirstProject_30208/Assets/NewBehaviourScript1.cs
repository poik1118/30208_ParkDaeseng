using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private string name;
    private int level = 1;

    public Player(string name)
    {
        this.name = name;
    }

    public void getInfo()
    {
        Debug.Log("이름 : " + name);
        Debug.Log("레벨 : " + level);
    }

    public void levelUP()
    {
        this.level++;
        Debug.Log("레벨업~!");
    }
}

public class NewBehaviourScript1 : MonoBehaviour
{
    void Start()
    {
        Player myPlayer = new Player("홍길동");

        myPlayer.getInfo();
        myPlayer.levelUP();
        myPlayer.getInfo();
    }
    void Update()
    {
        
    }
}
