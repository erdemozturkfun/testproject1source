using UnityEngine;
using System.Collections;
public class Raycaster : MonoBehaviour
{
    RaycastHit hit = new RaycastHit();
    Ray ray = new Ray();
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 1000.0f) & Input.GetMouseButtonDown(0))
        {
            Debug.Log("Hello!");
            
        }
    }
}
           
    
