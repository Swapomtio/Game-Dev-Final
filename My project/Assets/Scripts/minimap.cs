using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class minimap : MonoBehaviour
{
    [Header("References")]
    [SerializeField] RectTransform minimapPoint_1;
    [SerializeField] RectTransform minimapPoint_2;
    [SerializeField] Transform worldPoint_1;
    [SerializeField] Transform worldPoint_2;

    [Header("Player")]
    [SerializeField] RectTransform playerMinimap;
    [SerializeField] Transform playerWorld;

    float minimapRatio;
    //float xRatio;
    //float yRatio;

    void Awake(){
        CalculateMapRatio();
    }
    void Start()
    {
    }

    void Update()
    {
        playerMinimap.anchoredPosition = minimapPoint_1.anchoredPosition + new Vector2((playerWorld.position.x - worldPoint_1.position.x) * minimapRatio,
                                         (playerWorld.position.y - worldPoint_1.position.y) * minimapRatio);
    }
    public void CalculateMapRatio(){

        //distance world ignoring the Y axis
        Vector3 distanceWorldVector = worldPoint_1.position - worldPoint_2.position;
        distanceWorldVector.z = 0f;
        float distanceWorld = distanceWorldVector.magnitude;

        //distance minimap
        float distanceMinimap = Mathf.Sqrt(
            Mathf.Pow((minimapPoint_1.anchoredPosition.x - minimapPoint_2.anchoredPosition.x), 2) +
            Mathf.Pow((minimapPoint_1.anchoredPosition.y - minimapPoint_2.anchoredPosition.y), 2));

        minimapRatio = distanceMinimap / distanceWorld;

    }


}
