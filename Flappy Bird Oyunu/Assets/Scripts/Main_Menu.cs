using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{
    public void Main_Scene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
    public void Game_Scene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }
}
