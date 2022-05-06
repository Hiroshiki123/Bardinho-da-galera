using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trocar : MonoBehaviour
{
    public void CarregarFase()
    {
        SceneManager.LoadScene("fase1");
    }
    public void Sair()
    {
        Application.Quit();
    }
   
}
