using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class youWinImage : MonoBehaviour
{
    public Image img;
    public Button nextLvl;

    void Start()
    {
        img.enabled = false;
    }

    public void Activate()
    {
        img.enabled = true;
        nextLvl.gameObject.SetActive(true);
    }

}
