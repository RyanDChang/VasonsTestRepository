using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move_Prot : MonoBehaviour {

    public int playerSpeed = 10;
    private bool facingRight = true; // True == Right, False == Left
    public int playerJumpPower = 1250;
    private float moveX;

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    void PlayerMove () {
        // Controls
        moveX = Input.GetAxis("Horizontal");
        // Animations
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
        // Player direction
        if (moveX > 0.0f && facingRight == false)
        {
            FlipPlayer();
        }
        else if (moveX < 0.0f && facingRight == true)
        {
            FlipPlayer();
        }
        // Physics
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
	}

    void Jump ()
    {
        // Jump
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerJumpPower);
    }

    void FlipPlayer ()
    {
        facingRight = !facingRight;
        Vector2 temp_localScale = gameObject.transform.localScale;
        temp_localScale.x *= -1;
        transform.localScale = temp_localScale;
    }
}
