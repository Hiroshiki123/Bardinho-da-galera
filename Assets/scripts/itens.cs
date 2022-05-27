using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itens : MonoBehaviour
{
    private SpriteRenderer sr;
    private SphereCollider Box;

    
    public int Pontuação;
    // Start is called before the first frame update
    void Start()
    {
        
        Box = GetComponent<SphereCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f,0.5f,0f);
    }

    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            GameController.instance.totalScore += Pontuação;
            GameController.instance.UpdateScoreText();

            Destroy(gameObject, 0.2f);
        }
    }

}
