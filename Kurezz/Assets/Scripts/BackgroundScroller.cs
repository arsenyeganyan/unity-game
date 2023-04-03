using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BkagroundScroller : MonoBehaviour
{

    public BoxCollider2D colliderr;

    public Rigidbody2D rb;

    private float width;

    private float scrollSpeed = -20f;


    // Start is called before the first frame update
    void Start()
    {

        colliderr = GetComponent<BoxCollider2D>();

        rb = GetComponent<Rigidbody2D>();

        width = colliderr.size.x;

        colliderr.enabled = false;

        rb.velocity = new Vector2(scrollSpeed, 0);

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -width)
        {
            Vector2 resetPosition = new Vector2(width *  20f, 0);

            transform.position = (Vector2)transform.position + resetPosition;
        }
        
    }
}