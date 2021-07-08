using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Myball : MonoBehaviour
{
    Rigidbody rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();

        // rigid.velocity = Vector3.right;
        // rigid.velocity = new Vector3(2,3,0);
        
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetButtonDown("Jump"))
            rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);

        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"),0, Input.GetAxisRaw("Vertical"));
        rigid.AddForce(vec, ForceMode.Impulse);
        rigid.AddTorque(Vector3.up);
    }   

    private void OnTriggerStay(Collider other){
        if(other.name == "Jump"){
            rigid.AddForce(Vector3.up * 2, ForceMode.Impulse);
        }
    }
}
