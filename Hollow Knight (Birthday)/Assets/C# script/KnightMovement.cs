using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//comment test, wenyu do you see this
public class KnightMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D body;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);

        if (Input.GetKey(KeyCode.Z))
            body.velocity = new Vector2(body.velocity.x, speed);
        
    }
}
