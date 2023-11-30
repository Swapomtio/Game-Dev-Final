using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIWindow : MonoBehaviour
{
    [SerializeField] GameObject wumpus;
    public void Show() {
        GetComponent<Canvas>().enabled = true;
        wumpus.GetComponent<SpriteRenderer>().enabled = false;

    }
    public void Hide() {
        GetComponent<Canvas>().enabled = false;
        wumpus.GetComponent<SpriteRenderer>().enabled = true;
    }
}
