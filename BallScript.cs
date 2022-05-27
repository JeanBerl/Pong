using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    private float speed = 10;
    private float VerticalDirection = 0;
    private Rigidbody2D ball;
    // 1 When going to right and -1 when going to left
    private float horizontalDirection = 1;
    // Start is called before the first frame update
    void Start()
    {
        ball = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate(){
        ball.velocity = new Vector2(horizontalDirection, VerticalDirection) * speed;
    }
    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Racket"){
            horizontalDirection *= -1;
            // VerticalDirection = RandomIntExceptOne(-1, 1, 0);
            VerticalDirection = hitFactor(transform.position, collision.transform.position, collision.collider.bounds.size.y);
        }
        else if (collision.gameObject.tag == "Player1Wall"){
            Application.Quit();
            UnityEditor.EditorApplication.isPlaying = false;
        }
        else if (collision.gameObject.tag == "Player2Wall"){
            Application.Quit();
            UnityEditor.EditorApplication.isPlaying = false;
        }
        VerticalDirection *= -1;
        Debug.Log(transform.position);
    }

    private float hitFactor(Vector2 bolaPos, Vector2 jogPos, float tam){
	    return (bolaPos.y - jogPos.y)/tam;
    }
}
