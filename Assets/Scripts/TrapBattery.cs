using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapBattery : MonoBehaviour
{

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Parameters param = new Parameters();
            string msg = "DEATH BY BATTERY MIMIC";
            param.PutExtra(EventNames.GameJam_Events.DEATH_STRING, msg);
            print("fake battery obtained!");
            Destroy(gameObject);
            EventBroadcaster.Instance.PostEvent(EventNames.GameJam_Events.TRAP_BATTERY, param);
        }
    }
}
