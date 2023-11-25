using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fogManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the player GameObject is at the center of the "FOG" child GameObject
        if (IsPlayerAtCenterOfChild())
        {
            // Deactivate the "FOG" child GameObject
            Transform childToDeactivate = transform.Find("FOG");
            if (childToDeactivate != null)
            {
                childToDeactivate.gameObject.SetActive(false);
            }
            else
            {
                Debug.LogWarning("Child GameObject 'FOG' not found on the prefab.");
            }
        }
    }

    bool IsPlayerAtCenterOfChild()
    {
        // Check if the player GameObject is at the center of the "FOG" child GameObject
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            Transform fogChild = transform.Find("FOG");
            if (fogChild != null)
            {
                Collider fogChildCollider = fogChild.GetComponent<Collider>();
                if (fogChildCollider != null)
                {
                    return fogChildCollider.bounds.Contains(player.transform.position);
                }
                else
                {
                    Debug.LogWarning("Collider not found on the 'FOG' child GameObject.");
                    return false;
                }
            }
            else
            {
                Debug.LogWarning("Child GameObject 'FOG' not found on the prefab.");
                return false;
            }
        }
        else
        {
            Debug.LogWarning("Player GameObject not found.");
            return false;
        }
    }
}
