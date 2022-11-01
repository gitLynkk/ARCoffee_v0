using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionManager : MonoBehaviour
{

    // Indice della scena successiva da caricare nel build index
    [SerializeField]
    int indexOfNextScene;


    // Funzione per il caricamento della scena successiva a quella corrente
    public void LoadNextScene()
    {
        SceneManager.LoadScene(indexOfNextScene);
    }

    // Funzione per il caricamento della scena precedente a quella corrente
    public void LoadPreviousScene()
    {
        /// Questo frammento è stato utilizzato per cercare di fixare un bug
        /// BUG: Nel passaggio dal primo step al secondo e poi tornando indietro, la dimensione della scheda tecnica è compromessa.
        /* if (SceneManager.GetActiveScene().buildIndex != 1)
             SceneManager.LoadScene(indexOfScenes - 2);
         else
             SceneManager.LoadScene(currentSceneIndex - 1);
         */
        SceneManager.LoadScene(indexOfNextScene - 2);
    }


}
