using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonFunctionality : MonoBehaviour
{
    public void startGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void exitGame ()
    {
        Debug.Log("App Exit");
        Application.Quit();
    }
}
