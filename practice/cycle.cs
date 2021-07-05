using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cycle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if(Input.anyKeyDown)
        //     Debug.Log("Start");
        // if(Input.anyKey)
        //     Debug.Log("누르고 있음 ");
        Vector3 vec = new Vector3(0,0,0);
        transform.Translate(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"),0);
        if(Input.GetKeyDown(KeyCode.Return))
            Debug.Log("아이템 구입!");
        if(Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("왼쪽으로 이동");
        if(Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("오른쪽 이동을 멈춤");
        if(Input.GetMouseButton(0))
            Debug.Log("마우스 왼쪽");
        if(Input.GetMouseButton(1))
            Debug.Log("마우스 오른쪽");
        if(Input.GetButtonDown("Jump"))
            Debug.Log("Jump!!!");
    }
}
