using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{
    public Button Play;
    public Button Quit;
    public string levelName;

    void Start()
    {
        Play.GetComponent<Button>().onClick.AddListener(TaskOnPlay);
        Quit.GetComponent<Button>().onClick.AddListener(TaskOnQuit);
    }

    void TaskOnPlay()
    {
        SceneManager.LoadScene(levelName);
    }
    void TaskOnQuit()
    {
        Application.Quit();
    }

}
