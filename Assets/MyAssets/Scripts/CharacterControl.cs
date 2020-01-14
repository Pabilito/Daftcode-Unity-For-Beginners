using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    public float speed = 10;
    public VariableJoystick variableJoystick;
    public Rigidbody2D rb2D;
    public float jumpStrength = 7;
    public bool gameWon = false;


    // Start is called before the first frame update
    void Start()
    {
        variableJoystick = GameObject.FindWithTag("Joystick").GetComponent<VariableJoystick>();
    }

    // Update is called once per frame
    void Update()
    {
        /* Desktop movement
        moveX = Input.GetAxis("Horizontal");
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * speed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
        */
    }

    public void FixedUpdate()
    {
        if (!gameWon)
        {
            if (variableJoystick.Vertical > 0.5 && gameObject.GetComponent<Rigidbody2D>().velocity.y == 0)
            {
                Jump();
            }
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(variableJoystick.Horizontal * speed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }

    void Jump()
    {
        rb2D.AddForce(transform.up * jumpStrength, ForceMode2D.Impulse);
    }

}
