using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BaseCollisionTrap))]
public class ExplosiveTrap : MonoBehaviour {

    // Use this for initialization
    [Range(0, 10)]
    public float maxDuration;
    float duration;
    bool active;

	void Start()
    {
        active = false;
        GetComponent<Collider>().enabled = false;
    }
	
    void OnActivate()
    {
        duration = maxDuration;
        active = true;
        GetComponent<Collider>().enabled = true;
    }
    
    // Update is called once per frame
	void Update()
    {
        if (active == true)
        {
            duration -= Time.deltaTime;
            if (duration <= 0)
            {
                SendMessage("DeactivateTrap");
                active = false;
            }
        }
    }


    void OnPlayerCollision()
    {
        //todo kill player
    }
}