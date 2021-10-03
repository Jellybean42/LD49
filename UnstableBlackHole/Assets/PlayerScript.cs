using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public GameObject laserProj;
    Rigidbody2D rb;
    bool fired = false;
    AudioSource aS;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        aS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, transform.position + transform.up, 0.05f);
        if (Input.GetAxis("Vertical") > 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, transform.position+transform.up, 0.2f);
        }

        transform.up = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y);
    
        if(Input.GetMouseButton(0))
        {
            if (fired == false)
            {
                Instantiate(laserProj, transform.up*1.4f + transform.position, transform.rotation);
                aS.Play();
            }
            fired = !fired;
        }
    }
        
}
