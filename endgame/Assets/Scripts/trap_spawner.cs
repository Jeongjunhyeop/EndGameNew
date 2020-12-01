using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap_spawner : MonoBehaviour
{
    public GameObject spike_ball;


    public float fAniTime = 1.0f;  
    float fTimeCalc = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > fTimeCalc)
        {
            Instantiate(spike_ball,gameObject.transform.position,gameObject.transform.rotation);

            fTimeCalc = Time.time + fAniTime;
        }
    }
}
