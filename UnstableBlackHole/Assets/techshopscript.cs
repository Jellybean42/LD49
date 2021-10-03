using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class techshopscript : MonoBehaviour
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
        
    }

    public void ButtonLeft()
    {
        gm.LeftButton();
    }

    public void ButtonCenter()
    {
        gm.CenterButton();
    }

    public void ButtonRight()
    {
        gm.RightButton();
    }
}
