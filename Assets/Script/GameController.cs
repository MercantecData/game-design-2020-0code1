using JetBrains.Annotations;
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
    public GameObject Canvas;
    public Text condition;
    public GameObject background;
    //public Text Life;
    public Text kill;
    public Slider slider;
    [SerializeField]
    private Text ui_test;
    [SerializeField]
    private AudioClip clip_lose;
    [SerializeField]
    private AudioClip clip_win;
    [SerializeField]
    private AudioSource bg;

    private AudioSource musicSource;
    

    public Text Ui_test { get => ui_test; set => ui_test = value;}

    //public Text ui_LostText;

    public void Awake()
    {
        instance = this;
    }
    public int bullets = 10;

    public int life = 3;

    public int kills = 0;

    /// <summary>
    /// overføre fra scene til scene
    /// </summary>
    public void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    /// <summary>
    /// Player Health bar
    /// </summary>
    /// <param name="life"></param>
    public void setLife (int life)
    {
        this.life = life;
        //Life.text = "Health : " + life.ToString();
        slider.value = life;
    }

    /// <summary>
    /// Bullet Countdown
    /// </summary>
    /// <param name="bullets"></param>
    public void setBullets(int bullets)
    {
        this.bullets = bullets;
        ui_test.text =   "Bullets : "+ bullets.ToString();
    }

    /// <summary>
    /// Enemy Kills countdown
    /// </summary>
    /// <param name="kills"></param>
    public void setEnemyKill(int kills)
    {
        this.kills = kills;
        kill.text = "Killed "+ kills.ToString() + ": 3";
        if (kills == 3)
        {
            setWinCondition("YOU WIN");
            
        }
    }

    /// <summary>
    /// Ui win lost Text
    /// </summary>
    /// <param name="state"></param>
    public void setWinCondition(string state)
    {
        /// Instantiat af win and lose + background object, havde problem med scaling + dårlig practice af object
        #region Instantiat object
        //Text textObject = Instantiate(condition);
        //Image backG = Instantiate(background);
        //backG.transform.parent = Canvas.transform;
        //backG.transform.position = new Vector3(Screen.width * 0.5f, Screen.height * 0.5f, 0);
        //backG.GetComponent<Image>().color = new Color32(0, 0, 0,200);
        //textObject.transform.parent = Canvas.transform;
        //textObject.transform.position = new Vector3(Screen.width * 0.5f, Screen.height * 0.5f, 0);
        #endregion

        /// gøre det samme men med in setactive true/false
        musicSource = gameObject.AddComponent<AudioSource>();
        background.SetActive(true);
        bg.Stop();
        if (state == "YOU LOSE")
        {
            condition.color = new Color32(255, 0, 0, 255);
            musicSource.clip = clip_lose;
            musicSource.loop = true;
            musicSource.Play();
            
        }
        else
        {
            musicSource.clip = clip_win;
            musicSource.loop = true;
            musicSource.Play();
            condition.color = new Color32(0, 255, 0, 255);
        }
        condition.text = state;
        
    }


}
