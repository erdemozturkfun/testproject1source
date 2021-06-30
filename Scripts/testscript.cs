using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testscript : MonoBehaviour
{


    
    public GameObject gameController;
    Rigidbody rb;


    public Collision playercollision;






    // Start is called before the first frame update
    void Start()
    {

        //Destroy(gameObject,2f);


        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
       
            
         if (Input.GetKeyDown(KeyCode.Space))
         {
          rb.AddForce(Vector3.up * 175);
                   
         }
            
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
            rb.AddForce(Vector3.right * 200);
            }
        
            if(Input.GetKeyDown(KeyCode.LeftArrow))
            {
            rb.AddForce(Vector3.left * 200);
            }
       
  
        
       


    
    
    
    
    }
       public void OnCollisionEnter(Collision playercollision)
       {
        


        if (!gameController.GetComponent<GameController>().isFin == true)
        {
            if (playercollision.gameObject.tag == "Enemy")
            {
             gameController.GetComponent<GameController>().isDead = true;
                Destroy(gameObject);
            }
        }
        
            if(playercollision.gameObject.tag == "Finish")
            {
            gameController.GetComponent<GameController>().isFin = true;

        }


            
        
    
       }

}
