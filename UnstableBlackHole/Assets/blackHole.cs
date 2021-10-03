using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blackHole : MonoBehaviour
{
    gamemanagerscript gm;

    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<gamemanagerscript>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(gm.blackholeSize / 100, gm.blackholeSize / 100, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gm.playerHealth = 0;
        }
        if (collision.gameObject.layer != 6 && collision.gameObject.layer != 7)
        {
            Destroy(collision.gameObject);
            gm.blackholeSize++;
        }
        else
        {
            Destroy(collision.gameObject);
        }

        

    }
}
