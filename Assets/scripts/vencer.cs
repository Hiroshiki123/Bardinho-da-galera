using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class vencer : MonoBehaviour
{  
    private Rigidbody rig;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }
    void OnTriggerEnter(Collider collision)
    {
      
        if(collision.gameObject.tag == "fim")
        {
            
            SceneManager.LoadScene("vitoria");            
        }
    }     
   
}