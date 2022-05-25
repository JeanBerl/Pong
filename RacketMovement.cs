using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketMovement : MonoBehaviour
{
    private int up = 1;
    private int down = -1;
    private bool isPressingUp;
    
    private bool isPressingDown;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Vertical") == top){
            isPressingUp = true;
        }
        if (Input.GetAxisRaw("Vertical") == down){
            isPressingDown = true;
        }
    }
    void FixedUpdate(){
        if (isPressingUp){

            isPressingUp = false;
        }
        if (isPressingDown){
            isPressingDown = false;
        }
    }
}
