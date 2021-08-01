using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightIncrease : MonoBehaviour
{

    [SerializeField] private float curr_brightness;
    private Light myLight;

    // Start is called before the first frame update
    void Start()
    {
        myLight = GetComponent<Light>();
        EventBroadcaster.Instance.AddObserver(EventNames.GameJam_Events.BATTERY_GET, this.OnBatteryGet);
    }

    void OnDestroy()
    {
        EventBroadcaster.Instance.RemoveObserver(EventNames.GameJam_Events.BATTERY_GET);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnBatteryGet ()
    {
        curr_brightness += 0.25f;
        myLight.intensity = curr_brightness;
    }
}
