using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    public float speed;
    private Rigidbody2D rb;
    public Vector2 playerDirection;
    private Animator anim;
    bool tu;
    bool td = true;
    public GameObject shotgun;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float directionX = Input.GetAxisRaw("Horizontal");
        float directionY = Input.GetAxisRaw("Vertical");
        playerDirection = new Vector2(directionX, directionY).normalized;
        LookingDirection();
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(playerDirection.x * speed, playerDirection.y * speed);
    }

    void LookingDirection()
    {
        if(playerDirection.y > 0 || tu == true)
        {
            td = false;
            tu = true;
            shotgun.GetComponent<SpriteRenderer>().sortingOrder = 1;
            anim.SetBool("turnedBack", true);
            
        }
          if(playerDirection.y <0 || td == true)
        {
            td = true;
            tu = false;
            shotgun.GetComponent<SpriteRenderer>().sortingOrder = 3;
            anim.SetBool("turnedBack", false);

        }
    }
}


