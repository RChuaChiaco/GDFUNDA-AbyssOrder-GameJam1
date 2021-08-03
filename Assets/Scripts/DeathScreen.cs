using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScreen : MonoBehaviour
{
    [SerializeField] private GameObject pauseButtonGroup;
    [SerializeField] private GameObject pauseButton;
    private GameObject textBox;
    private GameObject deathTextBox;
    private GameObject resumeBtn;

    // Start is called before the first frame update
    void Start()
    {
        textBox = pauseButtonGroup.transform.Find("paused_text").gameObject;
        deathTextBox = pauseButtonGroup.transform.Find("death_text").gameObject;
        resumeBtn = pauseButtonGroup.transform.Find("btn_paused_resume").gameObject;
        pauseButtonGroup.SetActive(false);
        EventBroadcaster.Instance.AddObserver(EventNames.GameJam_Events.TRAP_BATTERY, this.OnTrapDeath);
        EventBroadcaster.Instance.AddObserver(EventNames.GameJam_Events.PLAYER_WIN, this.OnPlayerWin);
    }

    void OnDestroy()
    {
        EventBroadcaster.Instance.RemoveObserver(EventNames.GameJam_Events.TRAP_BATTERY);
        EventBroadcaster.Instance.RemoveObserver(EventNames.GameJam_Events.PLAYER_WIN);
    }

    // Code for death 
    private void OnTrapDeath(Parameters param)
    {
        string msg = param.GetStringExtra(EventNames.GameJam_Events.DEATH_STRING, "ERROR MESSAGE");
        Time.timeScale = 0;
        if (pauseButtonGroup != null && pauseButton != null && resumeBtn != null)
        {
            gameObject.SetActive(true);
            resumeBtn.SetActive(false);
            textBox.GetComponent<UnityEngine.UI.Text>().text = "YOU DIED";
            deathTextBox.GetComponent<UnityEngine.UI.Text>().text = msg;
            pauseButton.SetActive(false);
        }

    }

    // Code for winning 
    private void OnPlayerWin()
    {
        string msg = "EXITED THE DUNGEON";
        Time.timeScale = 0;
        if (pauseButtonGroup != null && pauseButton != null && resumeBtn != null)
        {
            gameObject.SetActive(true);
            resumeBtn.SetActive(false);
            textBox.GetComponent<UnityEngine.UI.Text>().text = "YOU WIN";
            deathTextBox.GetComponent<UnityEngine.UI.Text>().text = msg;
            pauseButton.SetActive(false);
        }

    }

}
