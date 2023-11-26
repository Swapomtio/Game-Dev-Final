using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUpdater : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Text hint;
    string hintStr = "";
    string defaultStr = "";
    [SerializeField] float proximityDistance = 5f;
    [SerializeField] float boxWidth = 40f;
    [SerializeField] float boxHeight = 20f;
    int nothing = 1;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rect boxRect = new Rect(transform.position.x - boxWidth / 2, transform.position.y - boxHeight / 2, boxWidth, boxHeight);
        string hintStr = "";
        string defaultStr = "You don't hear anything";
        GameObject wumpus = GameObject.FindWithTag("wumpus");
        GameObject pit = GameObject.FindWithTag("pit");
        GameObject bat = GameObject.FindWithTag("bat");

        if ( pit != null && boxRect.Contains(pit.transform.position)){
            nothing = 1;
            hintStr += "There is a pit nearby. ";
        }
        if ( bat != null && boxRect.Contains(bat.transform.position)){
            nothing = 1;
            hintStr += "There is a bat nearby. ";
        }
        if ( wumpus != null && boxRect.Contains(wumpus.transform.position)){
            nothing = 1;
            hintStr += "There is a wumpus nearby.";
        }
        if(nothing == 1){
            hint.text = hintStr;
            nothing = 0;
        }
        else{
            hint.text = defaultStr;
        }
        //Debug.Log(hintStr);
        //hint.text = hintStr;
    }

    

    
}
