using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Parameters param = new Parameters();
            string msg = "DEATH BY FALLING DEBRIS";
            param.PutExtra(EventNames.GameJam_Events.DEATH_STRING, msg);
            print("debris fallen!");
            EventBroadcaster.Instance.PostEvent(EventNames.GameJam_Events.TRAP_BATTERY, param);
        }

        if (coll.gameObject.tag == "Plate")
        {
            Destroy(gameObject);
        }
    }
}
