using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Retry : MonoBehaviour
{
    public Button yourButton;
    public GameObject deadBody;
    public GameObject player;
    public int numberOfBodies;
    public CharacterControl cc;
    //public int lives;
    public Image lives3;
    public Image lives2;
    public Image lives1;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }


    void TaskOnClick()
    {
        if (!cc.gameWon)
        {
            RemoveOne();
        }
    }

    public void RemoveBody()
    {
        deadBody = GameObject.FindGameObjectWithTag("DeadBody");
        Destroy(deadBody);
        numberOfBodies--;
    }

    public void RemoveOne()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        player.transform.position = new Vector3(0, 0, 0);

        if (numberOfBodies == 1)
        {
            lives3.enabled = true;
            deadBody = GameObject.FindGameObjectWithTag("DeadBody");
            Transform t = deadBody.transform;
            t.position = new Vector3(-30, 0, 0);
        }
        else if (numberOfBodies > 1)
        {
            if(numberOfBodies == 3)
            {
                lives1.enabled = true;
            }
            if (numberOfBodies == 2)
            {
                lives2.enabled = true;
            }
            RemoveBody();
        }
    }
}

