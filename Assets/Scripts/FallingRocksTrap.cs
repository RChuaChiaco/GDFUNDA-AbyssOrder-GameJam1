using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingRocksTrap : MonoBehaviour
{

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            print("debris fallen!");
            EventBroadcaster.Instance.PostEvent(EventNames.GameJam_Events.PLATE_ACTIVE);
        }
    }
}
