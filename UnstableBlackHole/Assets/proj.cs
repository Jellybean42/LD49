using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proj : MonoBehaviour
{
    float lifeSpan = 1f;
    gamemanagerscript gm;
    public AudioClip aC;

    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<gamemanagerscript>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, transform.position + transform.up, 0.05f);
        lifeSpan -= Time.deltaTime;
        if(lifeSpan < 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "fighter") 
        {
            AudioSource.PlayClipAtPoint(aC, Vector2.zero, 10);
            collision.gameObject.GetComponent<enemyFighter>().health -= 5;
            Destroy(gameObject);
            
        }
        if (collision.gameObject.tag == "acolyte")
        {
            AudioSource.PlayClipAtPoint(aC, Vector2.zero, 10);
            collision.gameObject.GetComponent<acolyteship>().health -= 5;
            Destroy(gameObject);
            
        }
        if (collision.gameObject.tag == "BH")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(aC, Vector2.zero);
            gm.playerHealth -= 5;
            Destroy(gameObject);
            
        }

    }
}
