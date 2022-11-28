using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour
{

    public void startgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    public void restart()
    {
        SceneManager.LoadScene("m1");

    }
    public void quit()
    {
        Application.Quit();

    }
}
