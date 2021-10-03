using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class acolyteship : MonoBehaviour
{
    gamemanagerscript gm;
    float state;
    float flip = 1;
    public float health = 100;
    public GameObject drop;
    Vector3 target;

    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<gamemanagerscript>();
        if (transform.position.x < 0) { flip = -1; }


    }
    private void Update()
    {
        if (health <= 0)
        {

            for (int i = 0; i < 10; i++)
            {
                if (Random.Range(-1, 1) >= 0) { Instantiate(drop, transform.position, Quaternion.identity); }
            }

            Destroy(gameObject);
        }
    }
        // Update is called once per frame
        void FixedUpdate()
    {
        target = new Vector3((gm.blackholeSize / 200 + 1.5f) * flip, 0, 0);
        transform.position = Vector2.MoveTowards(transform.position, target, 0.15f);
        if(transform.position == target)
        {
            gm.blackholeSize -= Time.deltaTime * 10;
        }
    }
}
