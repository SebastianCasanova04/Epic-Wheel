using UnityEngine;
using UnityEngine.SceneManagement;

public class ContolN1 : MonoBehaviour
{
    public void cambiarEsena(string nombreScena)
    {
        SceneManagement.LoadScene(nombreScena);
    }    

}
