using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody2D rbody;

    public static int hp = 1;

    private bool isGround;
    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    public void Jump()
    {
        if(isGround == true)
        {
            rbody.AddForce(Vector2.up * 400);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Ground")
        {
            isGround = true;
        }

        if(collision.collider.tag == "Die"  && hp > 0)
        {
            hp = 0;
            Destroy(gameObject);
        }

        if (collision.collider.tag == "Enemy" && hp > 0)
        {
            hp = 0;
            Destroy(gameObject);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            isGround = false;
        }
    }


}
