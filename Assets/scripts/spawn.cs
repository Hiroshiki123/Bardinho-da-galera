using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject Chao;
    private GameObject Cubo;
    float QuantidadeInimigos;

  [SerializeField] public GameObject objectToSpawn;

    private void Start()
    {

        QuantidadeInimigos = 0;
    }

    private void Update()
    {
        Debug.Log(QuantidadeInimigos);
    }


    private void OnTriggerEnter(Collider hit)
    {
        if (hit.tag =="Player") {
            Chao.SetActive(true);
            Debug.Log("sus");

            if (QuantidadeInimigos == 0 )
            {
                
                Instantiate(objectToSpawn);
                QuantidadeInimigos = QuantidadeInimigos + 1;
                
            }

            if (QuantidadeInimigos == 2)
            {
                Debug.Log("cheio");
            }

        }
    }
}