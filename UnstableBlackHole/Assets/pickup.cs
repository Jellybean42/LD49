using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    gamemanagerscript gm;
    Rigidbody2D rb;
    float timer = 0.25f;
    public AudioClip aC;
    // Start is called before the first frame update
    void Start()
    {
        
        gm = FindObjectOfType<gamemanagerscript>();
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Random.insideUnitCircle*10, ForceMode2D.Impulse);
    }

    private void Update()
    {
        timer -= Time.deltaTime;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        rb.AddForce((Vector3.zero - transform.position).normalized/(gm.blackholeSize/50));
        if(timer <= 0 && timer > -0.25) { rb.velocity = Vector2.zero; }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            gm.scrap++;
            Destroy(gameObject);
            AudioSource.PlayClipAtPoint(aC, Vector2.zero);
        }
    }
}
