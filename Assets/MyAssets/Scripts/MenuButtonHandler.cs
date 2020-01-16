using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuButtonHandler : MonoBehaviour
{
    public CharacterControl cc;
    public Button menu;
    public GameObject MenuPanel;

    void Start()
    {
        menu.GetComponent<Button>().onClick.AddListener(TaskOnMenu);
        MenuPanel = GameObject.FindGameObjectWithTag("MenuPanel");
        MenuPanel.SetActive(false);
    }

    void TaskOnMenu()
    {
        cc.gameWon = true;
        MenuPanel.SetActive(true);
    }




}
