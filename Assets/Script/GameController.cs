using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    ///trying to do an instantiate , but without success, since the object have to be
    ///fetch under  the canvas child. still havent found the solution yet, but might be good to try later
    //public GameObject winLostPrefab;

    [SerializeField]
    private Text ui_test;

    public Text Ui_test { get => ui_test; set => ui_test = value;}

    public Text ui_LostText;

    public void Awake()
    {
        instance = this;
    }
    public int bullets = 10;

    public void setBullets(int bullets)
    {
        this.bullets = bullets;
        ui_test.text =   "Bullets : "+ bullets.ToString();
    }
    public void setWinCondition(string state)
    {
        ui_LostText.text = state;
        
    }
}
