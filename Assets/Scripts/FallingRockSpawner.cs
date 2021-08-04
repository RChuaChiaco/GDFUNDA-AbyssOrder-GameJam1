using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingRockSpawner : MonoBehaviour
{
    [SerializeField] private GameObject debrisCopy;

    void Start()
    {
        this.debrisCopy.SetActive(false);
        EventBroadcaster.Instance.AddObserver(EventNames.GameJam_Events.PLATE_ACTIVE, this.OnSpawnEvent);
    }

    void OnDestroy()
    {
        EventBroadcaster.Instance.RemoveObserver(EventNames.GameJam_Events.PLATE_ACTIVE);
    }

    private void OnSpawnEvent()
    {
        GameObject rock = GameObject.Instantiate(debrisCopy, this.transform);
        rock.SetActive(true);
    }

}
