using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Funzione che si occupa di caricare la scena indicizzata con 1, corrispondente al menù nel build index
    public void LoadStart()
    {
        SceneManager.LoadScene(1);
    }

    // Funzione invocata alla e per la chiusa dell'applicazione
    public void Quit()
    {
        Application.Quit();
    }

}
