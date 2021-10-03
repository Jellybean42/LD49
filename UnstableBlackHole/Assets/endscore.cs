using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endscore : MonoBehaviour
{
    public Text scoreText;
    gamemanagerscript gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<gamemanagerscript>();

        scoreText.text = "You delayed the consumption of Earth for " + Mathf.Round(gm.score) + " seconds\n\nScore: " + Mathf.Round((gm.score*2) + gm.scrap + gm.blackholeSize);
    }

    void Update()
    {
        
    }
}
