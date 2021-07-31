using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialPageButtons : MonoBehaviour
{
    public void closeTutorial()
    {
        SceneManager.LoadScene(0);
    }
}
