using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public string _sceneToLoadOnPlay = "Menu";
    public GameObject menuUI;
    UnityEngine.SceneManagement.Scene scene;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    //Cierra el Menu de pausa y el tiempo coontinua * 1
    public void Resume()
    {
        menuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    //Se abre el Menú de pausa y el tiempo se multiplica * 0, por lo que se para
    public void Pause()
    {
        menuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    //El logueo de la escena del menu
    public void goMenu()
    {
        Time.timeScale = 1f;
        PlayerPrefs.SetString("_LastScene", scene.name);
        UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneToLoadOnPlay);
        //SceneManager.LoadScene(0);

    }
}
