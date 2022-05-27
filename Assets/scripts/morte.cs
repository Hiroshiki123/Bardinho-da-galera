using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class morte : MonoBehaviour
{
    public float TempoDeMorte;
    private player pla;
    private mouse mo;
    private Rigidbody rig;
    private raycast ray;
    
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }
    void OnCollisionEnter(Collision collision)
    {
      
        if(collision.gameObject.tag == "inimigo")
        {
            
            SceneManager.LoadScene("fase2");            
        }
    }     
   
}
