using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public GameObject buttonUI;

    public void OnDisable()
    {
        buttonUI.SetActive(false);
    }
}
