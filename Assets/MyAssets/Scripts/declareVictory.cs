using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class declareVictory : MonoBehaviour
{
    public youWinImage img;
    public CharacterControl cc;

    void OnCollisionEnter2D(Collision2D col)
    {
        cc.gameWon = true;
        img.Activate();
    }
}
