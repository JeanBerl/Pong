using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 10;
    [SerializeField]
    private string axis;
    private float direction = 0;
    private Rigidbody2D racket;
    // Start is called before the first frame update
    void Start()
    {
        racket = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update(){
        direction = Input.GetAxisRaw(axis);
    }
    // Updates for physics
    void FixedUpdate(){
        racket.velocity = new Vector2(0, direction) * speed;
    }
}
