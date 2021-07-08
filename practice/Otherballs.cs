using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Otherballs : MonoBehaviour
{
    //재질 접근
    MeshRenderer mesh;
    Material mat;
    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;

    }

    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.name == "myball")
            mat.color = new Color(0,0,0);
    }
    
    private void OnCollisionExit(Collision collision){
        mat.color = new Color(1,1,1);
    }


}
