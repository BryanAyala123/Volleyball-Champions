using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BacisMovement : MonoBehaviour{

    void Start(){
        
    }

    void Update(){

        Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);
        transform.position = transform.position + horizontal * Time.deltaTime;

    }
}