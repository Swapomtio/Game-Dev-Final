using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startAudioManager : MonoBehaviour
{
    [SerializeField] GameObject audioManagerPrefab;
    [SerializeField] AudioClip yourAudioClip;
    // Example script in a scene
    void Start()
    {
        Instantiate(audioManagerPrefab); // Reference the prefab in the Inspector
        AudioManager.Instance.PlaySound(yourAudioClip);
    }

}
