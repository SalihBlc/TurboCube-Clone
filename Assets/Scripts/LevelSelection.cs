using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{
    public int nextSceneLoad;
    public Button[] lvlButtons;


    // Start is called before the first frame update
    void Start()
    {
        nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
        int levelAt = PlayerPrefs.GetInt("levelAt", 4);

        for (int i = 0; i < lvlButtons.Length; i++)
        {
            if (i + 2 > levelAt)
                lvlButtons[i].interactable = false;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("picker"))
        {
            if (SceneManager.GetActiveScene().buildIndex == 6)
            {
                Debug.Log("You Completed ALL Levels");

                SceneManager.LoadScene(0);
            }
            else
            {
                //Move to next level
                SceneManager.LoadScene(nextSceneLoad);

                //Setting Int for Index
                if (nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
                {
                    PlayerPrefs.SetInt("levelAt", nextSceneLoad);
                }
            }
        }
    }
    public void level1()
    {
        AudioManager.Instance.PlaySFX("click");
        SceneManager.LoadScene(4);
    }
    public void level2()
    {
        AudioManager.Instance.PlaySFX("click");
        SceneManager.LoadScene(5);
    }
    public void level3()
    {
        AudioManager.Instance.PlaySFX("click");
        SceneManager.LoadScene(6);
    }
}
