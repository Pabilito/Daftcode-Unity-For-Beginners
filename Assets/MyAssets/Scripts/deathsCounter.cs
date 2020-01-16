using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deathsCounter : MonoBehaviour
{
    public int deaths = 0;
    public Text myText;

    void Update()
    {
        myText.text = deaths.ToString();
    }
}
