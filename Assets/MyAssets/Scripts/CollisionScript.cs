using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionScript : MonoBehaviour
{
    public GameObject deadBody;
    public GameObject player;
    public Retry removal;
    public Image lives3;
    public Image lives2;
    public Image lives1;
    public deathsCounter dCnt;

    IEnumerator ExampleCoroutine(int i)
    {
        yield return new WaitForSeconds(i);
    }

    public void Die()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        Transform t = player.transform;
        deadBody = GameObject.FindGameObjectWithTag("DeadBody");
        if (!(((t.position.x) < 2 && (t.position.x) > -2) && ((t.position.y) < 2 && (t.position.y) > -2))) //Prevents blocking at spawn
        {
            if(removal.numberOfBodies == 3)
            {
                player.transform.position = new Vector3(0, 0, 0);
                return;
            }
            removal.numberOfBodies++;
            Instantiate(deadBody, t.position, Quaternion.identity);
            if (removal.numberOfBodies == -1) //First time removal
            {
                removal.RemoveBody();
                removal.numberOfBodies = 1;
            }

            if (removal.numberOfBodies == 3)
            {
                lives1.enabled = false;
            }
            else if (removal.numberOfBodies == 2)
            {
                lives2.enabled = false;
            }
            else if (removal.numberOfBodies == 1)
            {
                lives3.enabled = false;
            }
            dCnt.deaths++;
        }

        StartCoroutine(ExampleCoroutine(2)); //Nie działa
        player.transform.position = new Vector3(0, 0, 0);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Die();
    }

}

