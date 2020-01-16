using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class nextLevelHangler : MonoBehaviour
{
    public Button buttonNext;
    public Button menuButton;
    public string levelName;

    void Start()
    {
        buttonNext.GetComponent<Button>();
        buttonNext.onClick.AddListener(TaskOnClick);
        buttonNext.gameObject.SetActive(false);

        menuButton.GetComponent<Button>();
        menuButton.onClick.AddListener(TaskOnMenu);
        menuButton.gameObject.SetActive(false);
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene(levelName);
    }

    void TaskOnMenu()
    {
        SceneManager.LoadScene(0);
    }
}
