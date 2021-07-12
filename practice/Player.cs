using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    Rigidbody rigid;
    public int itemCount=0; 
    public float jumpPower = 10;
    bool isJump;
    public GameMangerScript manager;
    AudioSource audio;
    void Awake(){
        isJump = false;
        rigid = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
    }
 
    void Update(){
        if(Input.GetButton("Jump") && !isJump){
            isJump = true; 
            rigid.AddForce(new Vector3(0,jumpPower,0), ForceMode.Impulse);
        }
            
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        rigid.AddForce(new Vector3(h,0,v), ForceMode.Impulse);
    }

    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "floor")
            isJump = false;
    }
    
    void OnTriggerEnter(Collider other){
        if(other.tag == "item"){
            itemCount++;
            audio.Play();
            other.gameObject.SetActive(false);
        }
        else if(other.tag == "Finish"){
            if(itemCount == manager.totalItemCount){
                //Clear
                SceneManager.LoadScene("Scene2");
            }else{
                //restart
                SceneManager.LoadScene("First");
            }
        }
    }
}
