using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGame : MonoBehaviour
{
    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            print("you win!");
            EventBroadcaster.Instance.PostEvent(EventNames.GameJam_Events.PLAYER_WIN);
        }
    }
}
