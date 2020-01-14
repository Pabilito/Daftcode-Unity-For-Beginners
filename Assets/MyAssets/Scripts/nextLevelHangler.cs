using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nextLevelHangler : MonoBehaviour
{
    public Button buttonNext;
    void Start()
    {
        buttonNext.GetComponent<Button>();
        buttonNext.onClick.AddListener(TaskOnClick);
        buttonNext.gameObject.SetActive(false);
    }

    void TaskOnClick()
    {
        Debug.Log("Hello");
        //change scene
    }
}
