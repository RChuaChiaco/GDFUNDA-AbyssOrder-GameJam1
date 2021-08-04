using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingRocksTrap : MonoBehaviour
{
    [SerializeField] private GameObject debrisCopy;
    [SerializeField] private List<GameObject> debrisSpawnList;

    private float ticks = 0.0f;
    private const float SPAWN_INTERVAL = 0.25f;

    private float destroyTicks = 0.0f;
    private const float DESTROY_INTERVAL = 5.0f;

    bool activated;

    void Start()
    {
        this.activated = false;
        this.debrisCopy.SetActive(false);
    }

    void Update()
    {
        print("Activated (Update): " + getActivated()); // keeps on outputting false :((

        if(getActivated())
        {
            this.debrisCopy.SetActive(true);
            this.ticks += Time.deltaTime;
            this.destroyTicks += Time.deltaTime;

            if (this.ticks >= SPAWN_INTERVAL)
            {
                this.ticks = 0.0f;
                GameObject debris = GameObject.Instantiate(this.debrisCopy, this.transform);
                debris.SetActive(true);
                this.debrisSpawnList.Add(debris);

                Vector3 position = debris.transform.localPosition;
                position.y += 2.0f;

                debris.transform.localPosition = position;
            }

            if (this.destroyTicks >= DESTROY_INTERVAL)
            {
                this.destroyTicks = 0.0f;

                for (int i = 0; i < this.debrisSpawnList.Count; i++)
                {
                    GameObject.Destroy(this.debrisSpawnList[i]);
                }

                this.debrisSpawnList.Clear();
            }
        }
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            setActivated(true);
            print("floor button trap activated!");
            print("Floor Slab Activation: " + activated);
        }
    }

    void setActivated(bool activation)
    {
        this.activated = activation;
        print("activated (SetActivated): " + this.activated);
    }

    public bool getActivated()
    {
        return this.activated;
    }
}
