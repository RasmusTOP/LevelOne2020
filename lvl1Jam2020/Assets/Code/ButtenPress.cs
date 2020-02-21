using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtenPress : MonoBehaviour
{
    public Sprite pressedSpr, notePressedSpr;
    private GameObject[] Doors;
    public bool pressed;
    private SpriteRenderer spriteR;
    // Start is called before the first frame update
    void Start()
    {
        Doors = GameObject.FindGameObjectsWithTag("Door");
        spriteR = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(pressed == true)
        {
            spriteR.sprite = pressedSpr;
        }else{
            spriteR.sprite = notePressedSpr;
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.isTrigger != true){
            foreach (var door in Doors)
            {
                if(pressed == false)
                {
                    door.SetActive(false);
                }else{
                    door.SetActive(true);
                }
                
            }
            pressed = !pressed;
        }
    }
}
