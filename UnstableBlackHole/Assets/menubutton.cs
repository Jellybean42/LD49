using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menubutton : MonoBehaviour
{
    public GameObject menu;
    public GameObject into;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonPress()
    {

        into.SetActive(true);
        menu.SetActive(false);
        
    }

}
