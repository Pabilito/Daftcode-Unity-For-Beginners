using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialText : MonoBehaviour
{
    public Button acknowledge;
    public CharacterControl cc;

    void Start()
    {
        acknowledge.GetComponent<Button>().onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        cc.gameWon = false;
        acknowledge.enabled = false;
    }
}
