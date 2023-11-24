using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControls : MonoBehaviour
{
    public GameObject gameoverPanel;
    public GameObject pausedPanel;

    public void ContinueButton()
    {
        AudioManager.Instance.PlaySFX("click");
        SceneManager.LoadScene(1);
    }

    public void LevelsButton()
    {
        AudioManager.Instance.PlaySFX("click");
        SceneManager.LoadScene(2);
    }
    public void StoreButton()
    {
        AudioManager.Instance.PlaySFX("click");
        SceneManager.LoadScene(3);
    }
    public void NewGameButton()
    {
        AudioManager.Instance.PlaySFX("click");
        PlayerPrefs.DeleteKey("levelAt");
        PlayerPrefs.SetInt("levelAt", 2);
        SceneManager.LoadScene(1);
    }
    public void BackButton()
    {
        AudioManager.Instance.PlaySFX("click");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void BackStoreButton()
    {
        AudioManager.Instance.PlaySFX("click");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
    public void BackToMenu()
    {
        AudioManager.Instance.PlaySFX("click");
        SceneManager.LoadScene(1);
    }
    public void ContinueGame()
    {
        AudioManager.Instance.PlaySFX("click");
        gameoverPanel.SetActive(false);
        Time.timeScale = 1f;
    }
    public void ContinueGamePaused()
    {
        AudioManager.Instance.PlaySFX("click");
        pausedPanel.SetActive(false);
        Time.timeScale = 1f;
    }
    public void PauseButton()
    {
        AudioManager.Instance.PlaySFX("click");
        pausedPanel.SetActive(enabled);
        Time.timeScale = 0f;
    }
}
