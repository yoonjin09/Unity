using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 target = new Vector3(8,1,-8);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        // transform.position = 
        //     Vector3.MoveTowards(transform.position, target,1f);

        // Vector3 velo = Vector3.zero;
        // transform.position =
        //     Vector3.SmoothDamp(transform.position,target, ref velo, 0.1f);

        // transform.position =
        //     Vector3.Lerp(transform.position, target,0.1f);

        transform.position =
            Vector3.Slerp(transform.position, target,0.1f);
    }
}
