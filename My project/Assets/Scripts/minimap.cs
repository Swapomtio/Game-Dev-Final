using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minimap : MonoBehaviour
{
    [Header("Player")]
    public RectTransform playerMinimap;
    public Transform playerWorld;
    

    private float minimapRatio;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake(){
        CalculateMapRatio();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CalculateMapRatio()
    {
        //distance world ignoring Y axis
        /*Vector3 distanceWorldVector = worldPoint_1.position - worldPoint_2.position;
        distanceWorldVector.y = 0f;
        float distanceWorld = distanceWorldVector.magnitude;

        //distance minimap
        float distanceMinimap = Mathf.Sqrt(
            Mathf.Pow((minimapPoint_1.anchoredPosition.x - minimapPoint_2.anchoredPosition.x),2) +
            Mathf.Pow((minimapPoint_1.anchoredPosition.y - minimapPoint_2.anchoredPosition.y),2));

        minimapRatio = distanceMinimap / distanceWorld;*/
    }
}
