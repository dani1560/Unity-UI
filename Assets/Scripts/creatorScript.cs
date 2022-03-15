using UnityEngine;
using UnityEngine.SceneManagement;

public class creatorScript : MonoBehaviour
{
    public void onBack()
    {
        globalVariable.backward = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void onBackFromShopfer()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        globalVariable.forward = true;
    }

    public void finalWindow()
    {
        SceneManager.LoadScene("finalWindow");
    }

    public void allDone()
    {
        SceneManager.LoadScene("Panel");
        globalVariable.backward = true;
    }
}
