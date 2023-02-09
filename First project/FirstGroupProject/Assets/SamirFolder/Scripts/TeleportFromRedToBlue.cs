using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportFromRedToBlue : MonoBehaviour
{
 

    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter(Collider other)
    {

        Vector3 offset = new Vector3(-5, 0, 0);
        
        if (other.tag == "Player")
        {
            Debug.Log("JOE");
            if (gameObject.name == "Portal1")
            {
                GameObject portal2 = GameObject.Find("Portal2");

                other.transform.position = portal2.transform.position + offset;
                
                

            }

            if (gameObject.name == "Portal2")
            {
                GameObject portal1 = GameObject.Find("Portal1");

                other.transform.position = portal1.transform.position + offset;

            }
        }
    }
}
