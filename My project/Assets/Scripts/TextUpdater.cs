using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextUpdater : MonoBehaviour
{
    // Start is called before the first frame update
    string hint = "";
    [SerializeField] float proximityDistance = 5f;
    [SerializeField] float boxWidth = 40f;
    [SerializeField] float boxHeight = 20f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rect boxRect = new Rect(transform.position.x - boxWidth / 2, transform.position.y - boxHeight / 2, boxWidth, boxHeight);
        string hint = "";
        GameObject wumpus = GameObject.FindWithTag("wumpus");
        GameObject pit = GameObject.FindWithTag("pit");
        GameObject bat = GameObject.FindWithTag("bat");

        if ( pit != null && boxRect.Contains(pit.transform.position)){
            hint += "There is a pit nearby. ";
        }
        if ( bat != null && boxRect.Contains(bat.transform.position)){
            hint += "There is a bat nearby. ";
        }
        if ( wumpus != null && boxRect.Contains(wumpus.transform.position)){
            hint += "There is a wumpus nearby.";
        }
        Debug.Log(hint);
    }

    

    
}
