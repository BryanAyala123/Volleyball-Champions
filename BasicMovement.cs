using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float moveSpeed1 = 10f;
    public Rigidbody2D p1;
    // Start is called before the first frame update
    void Start()
    {
        p1 = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"),0.0f, 0.0f);
        transform.position = transform.position + horizontal * Time.deltaTime*moveSpeed;
        if (Input.GetKeyDown(KeyCode.W)){
            p1.velocity = new Vector2(p1.velocity.x,moveSpeed1);

        }
    }
}
