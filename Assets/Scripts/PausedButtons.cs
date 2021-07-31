using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausedButtons : MonoBehaviour
{

    [SerializeField] private GameObject pauseButtonGroup;
    [SerializeField] private GameObject pauseButton;

    public void resumeGame()
    {
        Time.timeScale = 1;
        if (pauseButtonGroup != null && pauseButton != null)
        {
            pauseButtonGroup.SetActive(false);
            pauseButton.SetActive(true);
        }
    }

    public void backToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void restartGame ()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
}
