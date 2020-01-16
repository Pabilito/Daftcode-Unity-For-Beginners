using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class nextLevelHangler : MonoBehaviour
{
    public Button buttonNext;
    public string levelName;

    void Start()
    {
        buttonNext.GetComponent<Button>();
        buttonNext.onClick.AddListener(TaskOnClick);
        buttonNext.gameObject.SetActive(false);
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene(levelName);
    }
}
