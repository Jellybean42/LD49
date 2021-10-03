using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gamemanagerscript : MonoBehaviour
{
    public float score = 0;
    float fTimer = 0;
    float aTimer = 0;
    public float scrap = 0;/// / / / / / / / /
    public GameObject fighter;
    public GameObject Acolyte;
    public GameObject spawner1;
    public GameObject aSpawner1;
    public GameObject aSpawner2;
    public GameObject spawner2;

    public float playerHealth = 250;
    public GameObject playerPrefab;

    public Text leftButton;
    public Text centerButton;
    public Text rightButton;
    public Text scrapCount;

    bool menuEnabled = false;
    public GameObject menu;

    public Image healthBar;
    public float blackholeSize = 500;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime;
        fTimer += Time.deltaTime;
        aTimer += Time.deltaTime;

        healthBar.fillAmount = playerHealth / 250;

        scrapCount.text = "SCRAP: " + scrap;
        if (score < 30)
        {
            if (fTimer >= 3)
            {
                if(Random.Range(-1f, 1f)>0f)
                {
                    Instantiate(fighter, spawner1.transform.position+new Vector3(Random.Range(-5, 5), 0, 0), Quaternion.identity);
                }
                else
                {
                    Instantiate(fighter, spawner2.transform.position + new Vector3(Random.Range(-5, 5), 0, 0), Quaternion.identity);
                }
                fTimer = 0;
            }
        }
        if (score > 30 && score < 60)
        {
            if (fTimer >= 3)
            {
                if (Random.Range(-1f, 1f) > 0)
                {
                    Instantiate(fighter, spawner1.transform.position + new Vector3(Random.Range(-5, 5), 0, 0), Quaternion.identity);
                }
                else
                {
                    Instantiate(fighter, spawner2.transform.position + new Vector3(Random.Range(-5, 5), 0, 0), Quaternion.identity);
                }
                fTimer = 0;
            }
            if (aTimer >= 12)
            {
                if (Random.Range(-1f, 1f) > 0)
                {
                    Instantiate(Acolyte, aSpawner1.transform.position, Quaternion.identity);
                }
                else
                {
                    Instantiate(Acolyte, aSpawner2.transform.position, Quaternion.identity);
                }
                aTimer = 0;
            }
        }
        if (score > 60 && score < 180)
        {
            if (fTimer >= 4)
            {
                for(int i = 0; i < 3; i++)
                {
                    if (Random.Range(-1f, 1f) > 0)
                    {
                        Instantiate(fighter, spawner1.transform.position + new Vector3(Random.Range(-5, 5), 0, 0), Quaternion.identity);
                    }
                    else
                    {
                        Instantiate(fighter, spawner2.transform.position + new Vector3(Random.Range(-5, 5), 0, 0), Quaternion.identity);
                    }
                    fTimer = 0;
                }
            }
            if (aTimer >= 8)
            {
                if (Random.Range(-1f, 1f) > 0)
                {
                    Instantiate(Acolyte, aSpawner1.transform.position, Quaternion.identity);
                }
                else
                {
                    Instantiate(Acolyte, aSpawner2.transform.position, Quaternion.identity);
                }
                aTimer = 0;
            }
        }
        if (score > 180 && score < 240)
        {
            if (fTimer >= 6)
            {
                for (int i = 0; i < 6; i++)
                {
                    if (Random.Range(-1f, 1f) > 0)
                    {
                        Instantiate(fighter, spawner1.transform.position + new Vector3(Random.Range(-5, 5), 0, 0), Quaternion.identity);
                    }
                    else
                    {
                        Instantiate(fighter, spawner2.transform.position + new Vector3(Random.Range(-5, 5), 0, 0), Quaternion.identity);
                    }
                    fTimer = 0;
                }
            }
            if (aTimer >= 7)
            {
                if (Random.Range(-1f, 1f) > 0)
                {
                    Instantiate(Acolyte, aSpawner1.transform.position, Quaternion.identity);
                }
                else
                {
                    Instantiate(Acolyte, aSpawner2.transform.position, Quaternion.identity);
                }
                aTimer = 0;
            }
        }

        if (score > 240 && score < 270)
        {
            if (fTimer >= 6)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (Random.Range(-1f, 1f) > 0)
                    {
                        Instantiate(fighter, spawner1.transform.position + new Vector3(Random.Range(-5, 5), 0, 0), Quaternion.identity);
                    }
                    else
                    {
                        Instantiate(fighter, spawner2.transform.position + new Vector3(Random.Range(-5, 5), 0, 0), Quaternion.identity);
                    }
                    fTimer = 0;
                }
            }
            if (aTimer >= 6)
            {
                if (Random.Range(-1f, 1f) > 0)
                {
                    Instantiate(Acolyte, aSpawner1.transform.position, Quaternion.identity);
                }
                else
                {
                    Instantiate(Acolyte, aSpawner2.transform.position, Quaternion.identity);
                }
                aTimer = 0;
            }
        }

        if (score > 270)
        {
            if (fTimer >= 6)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (Random.Range(-1f, 1f) > 0)
                    {
                        Instantiate(fighter, spawner1.transform.position + new Vector3(Random.Range(-5, 5), 0, 0), Quaternion.identity);
                    }
                    else
                    {
                        Instantiate(fighter, spawner2.transform.position + new Vector3(Random.Range(-5, 5), 0, 0), Quaternion.identity);
                    }
                    fTimer = 0;
                }
            }
            if (aTimer >= 6)
            {
                Instantiate(Acolyte, aSpawner1.transform.position, Quaternion.identity);
                Instantiate(Acolyte, aSpawner2.transform.position, Quaternion.identity);
                aTimer = 0;
            }
        }

        if (Input.GetButtonDown("menu"))
        {
            menuEnabled = !menuEnabled;
            menu.SetActive(menuEnabled);
        }

        if(menuEnabled)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }

        if(blackholeSize <= 50)
        {
            //end the game
            SceneManager.LoadScene(2);
        }
        if(playerHealth <= 0)
        {
            
            if(scrap < 50)
            {
                SceneManager.LoadScene(2);
            }
            Destroy(FindObjectOfType<PlayerScript>().gameObject);
        }

    }

    public void LeftButton()
    {
        if(scrap >= 50)
        {
            if (Random.Range(-1, 1) >= 0)
            {
                scrap += 50;
            }
            else
            {
                scrap -= 50;
            }
        }
        
    }

    public void CenterButton()
    {
        if(scrap >= 100)
        {
            if(playerHealth <= 0)
            {
                Instantiate(playerPrefab, new Vector3(0, 10, 0), Quaternion.identity);
            }
            playerHealth = 250;
            scrap -= 100;
        }
    }

    public void RightButton()
    {
        if (scrap >= 250)
        {
            scrap -= 250;
            enemyFighter[] ef = FindObjectsOfType<enemyFighter>();
            foreach(enemyFighter enF in ef)
            {
                enF.health = 0;
            }
            acolyteship[] aship = FindObjectsOfType<acolyteship>();
            foreach (acolyteship acS in aship)
            {
                acS.health = 0;
            }
        }
    }
}
