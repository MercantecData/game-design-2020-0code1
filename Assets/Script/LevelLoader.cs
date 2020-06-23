using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;

    public float transitionTime = 1f;
    // Update is called once per frame

    public void LoadNextLevel()
    {
        //StartCoroutine((string)LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    IEnumerable LoadLevel (int levelIndex)
    {
        //Play animation
        transition.SetTrigger("Start");

        //Wait
        yield return new WaitForSeconds(transitionTime);
        //Load Scene
        SceneManager.LoadScene(levelIndex);
    }

}
