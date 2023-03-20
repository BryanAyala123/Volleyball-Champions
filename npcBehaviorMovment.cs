using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcBehaviorMovment : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpspeed = 10f;
    public Rigidbody2D p2;
    // Start is called before the first frame update
    void Start()
    {
      p2 = GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void Update()
    {
       Vector3 horizontal = new Vector3 (Input.GetAxis("Horizontal1"), 0.0f, 0.0f);
       transform.position = transform.position + horizontal* Time.deltaTime*moveSpeed;
       if (Input.GetKeyDown(KeyCode.UpArrow)){
        p2.velocity = new Vector2 (p2.velocity.x,jumpspeed);
       }
    }
}