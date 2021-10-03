using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFighter : MonoBehaviour
{
    int state = 0;
    float reload = 3;
    public GameObject laser;
    public GameObject drop;
    public Vector3[] waypoints;
    public float health = 50;
    GameObject player;
    Vector2 dir;
    AudioSource aS;

    // Start is called before the first frame update
    void Start()
    {
        aS = GetComponent<AudioSource>();

        StartCoroutine(LateStart(0.1f));
        player = FindObjectOfType<PlayerScript>().gameObject;
        
        waypoints[0] = new Vector3(transform.position.x, 0, 0);
        waypoints[1] = new Vector3(Mathf.Sin(45), Mathf.Cos(45), 0) * transform.position.x;
        waypoints[2] = new Vector3(0, transform.position.x, 0);
        waypoints[3] = new Vector3(waypoints[1].x * -1, waypoints[1].y, 0);
        waypoints[4] = new Vector3(transform.position.x*-1, 0, 0);
    }
    IEnumerator LateStart(float time)
    {
        yield return new WaitForSeconds(time);

        if(player==null)
        {
            Destroy(gameObject);
        }

    }

    private void Update()
    {
        if(health <= 0)
        {
            
            for (int i = 0; i < 5; i++)
            {
                if (Random.Range(-1, 1) >= 0) { Instantiate(drop, transform.position, Quaternion.identity); }
            }

            Destroy(gameObject);
        }

        reload -= Time.deltaTime;
        if (reload <= 0 && player != null)
        {
            GameObject proj = Instantiate(laser, transform.position, Quaternion.LookRotation(Vector3.forward, dir));
            proj.transform.up =  player.transform.position - transform.position;
            reload = 1+ Random.Range(-0.25f, 0.25f);
            aS.Play();
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (state < 5)
        {
            dir = Vector2.MoveTowards(transform.position, waypoints[state], 0.2f);
            transform.position = dir;
            if (transform.position == waypoints[state])
            {
                state++;
            }
        }

        if(state >= 5)
        {
            if(player != null && Vector2.Distance(transform.position, player.transform.position) > 2.5)
            {
                dir = Vector2.MoveTowards(transform.position, player.transform.position, 0.15f);
                transform.position = dir;
            }
        }
        
    }



}
