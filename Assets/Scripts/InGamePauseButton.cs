using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGamePauseButton : MonoBehaviour
{

    [SerializeField] private GameObject pauseButtonGroup;
    [SerializeField] private GameObject pauseButton;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            this.pauseGame();
        }
    }

    public void pauseGame()
    {
        Time.timeScale = 0;
        if (pauseButtonGroup != null && pauseButton != null)
        {
            pauseButtonGroup.SetActive(true);
            pauseButton.SetActive(false);
        }
    }
}
