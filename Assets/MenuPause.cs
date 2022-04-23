using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPause : MonoBehaviour
{
    public static bool gameIsPaused = false;
    [SerializeField]
    private GameObject pauseMenuUI;
    [SerializeField]
    private GameObject assistentUI;
    [SerializeField]
    private GameObject textAssistentUI;
 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
                Resume();
            else
                Paused();
        }
    }

    public void Resume()
    {
        textAssistentUI.SetActive(true);
        assistentUI.SetActive(true);
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }
    public void Paused()
    {
        textAssistentUI.SetActive(false);
        assistentUI.SetActive(false);
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }
 }
