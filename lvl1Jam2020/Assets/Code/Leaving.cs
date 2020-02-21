using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leaving : MonoBehaviour
{
    private Rigidbody2D rb;
    public int speed;
    public bool isNotLit;
    // Start is called before the first frame update
    void Start()
    {
        isNotLit = true;
        rb = GetComponent<Rigidbody2D>();
        Physics2D.IgnoreCollision(this.GetComponent<Collider2D>(),GameObject.Find("/Player").GetComponent<Collider2D>());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if(isNotLit == true)
        {
            rb.constraints = RigidbodyConstraints2D.None;
            //rb.velocity = new Vector2(speed,rb.velocity.y);
        }else
        {
            rb.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
            //rb.velocity = new Vector2(0,0);
        }
        rb.velocity = new Vector2(speed,rb.velocity.y);
    }
    void OnTriggerEnter2D(Collider2D col)
    {

        switch (col.gameObject.tag )
        {
            case "Exit":
            Debug.Log("you Lose");
            break;

            case "Light":
            isNotLit = false;
            break;
        }

        if(col.gameObject.tag == "Exit")
        {
            Debug.Log("you Lose");
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if(col.gameObject.tag == "Light")
        {
           isNotLit = true;
        }
    }
}
