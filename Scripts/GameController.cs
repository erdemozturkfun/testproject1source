using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public bool isDead = false;
    public bool isFin = false;
    public bool Spawned = false;


    public GameObject newPlayer;
    public GameObject winText;
    public GameObject killText;
    public GameObject player;


    public Transform Spawn;



    // Start is called before the first frame update
    void Start()
    {





    }

    // Update is called once per frame
    void Update()
    {


        if (isDead == true)
        {
            killText.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(newPlayer, Spawn.position, Quaternion.identity);
                Spawned = true;
            }


        }

        if (isFin == true)
        {
            winText.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("Level2");
            }

        }

        if (Spawned == true)
        {
            killText.SetActive(false);
            isDead = false;
            Spawned = false;
        }

    }

    
}

  