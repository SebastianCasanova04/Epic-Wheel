using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControlador : MonoBehaviour
{
    public void cambiarEscena(string nombreScena){
        SceneManager.LoadScene(nombreScena);
        SceneManager.LoadScene(nombreScena);
    }

        

}