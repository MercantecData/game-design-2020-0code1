using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    public Text ui_test;

    public void Awake()
    {
        instance = this;
    }
    public int bullets = 10;

    public void setBullets(int bullets)
    {
        this.bullets = bullets;
        print(bullets);
    }
    
}
