using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickup : MonoBehaviour
{
    void OnTriggerEnter(Collider coll)
    {
        if(coll.gameObject.tag == "Player")
        {
            print("battery obtained!");
            Destroy(gameObject);
            EventBroadcaster.Instance.PostEvent(EventNames.GameJam_Events.BATTERY_GET);
        }
    }
}
