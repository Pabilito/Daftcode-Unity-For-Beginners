using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuButtonHandler : MonoBehaviour
{
    public CharacterControl cc;
    public Button menu;
    public GameObject MenuPanel;
    public Button resume;
    public Button returnToMenu;
    public Button restart;
    public string levelName;
    

    void Start()
    {
        menu.GetComponent<Button>().onClick.AddListener(TaskOnMenu);
        resume.GetComponent<Button>().onClick.AddListener(TaskOnResume);
        returnToMenu.GetComponent<Button>().onClick.AddListener(TaskOnReturnToMenu);
        restart.GetComponent<Button>().onClick.AddListener(TaskOnRestart);

        MenuPanel = GameObject.FindGameObjectWithTag("MenuPanel");
        MenuPanel.SetActive(false);
    }

    void TaskOnMenu()
    {
        cc.gameWon = true;
        MenuPanel.SetActive(true);
    }

    void TaskOnResume()
    {
        cc.gameWon = false;
        MenuPanel.SetActive(false);
    }

    void TaskOnReturnToMenu()
    {
        SceneManager.LoadScene(0);
    }

    void TaskOnRestart()
    {
        SceneManager.LoadScene(levelName);
    }

}
