using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapDoor : MonoBehaviour
{
    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Parameters param = new Parameters();
            string msg = "DEATH BY FAKE EXIT";
            param.PutExtra(EventNames.GameJam_Events.DEATH_STRING, msg);
            print("trap activated!");
            EventBroadcaster.Instance.PostEvent(EventNames.GameJam_Events.TRAP_BATTERY, param);
        }
    }
}
