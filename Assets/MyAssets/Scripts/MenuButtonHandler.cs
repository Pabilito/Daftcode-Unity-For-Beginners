using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuButtonHandler : MonoBehaviour
{
    public CharacterControl cc;
    public Button menu;

    void Start()
    {
        menu.GetComponent<Button>().onClick.AddListener(TaskOnMenu);
    }

    void TaskOnMenu()
    {
        cc.gameWon = true;
    }

}
