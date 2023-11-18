using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class mapGeneration : MonoBehaviour
{
    [SerializeField] GameObject[] Rooms;
    [SerializeField] GameObject WumpusPrefab;
    [SerializeField] GameObject BatPrefab;
    [SerializeField] GameObject PitPrefab;
    [SerializeField] GameObject PlayerPrefab;

    void Start()
    {
        if (Rooms.Length == 0)
        {
            Debug.LogError("No game objects in the array. Please assign game objects in the Unity editor.");
            return;
        }
        //SpawnRandomGameObjects();
        SpawnWumpusInAllRooms(WumpusPrefab);
    }
    void SpawnWumpusInAllRooms(GameObject Wumpus)
    {
        foreach (GameObject room in Rooms)
        {
            Vector3 spawnPos = room.transform.position;

            if (Wumpus == null)
            {
                Debug.LogError("Wumpus prefab is not assigned. Please assign the Wumpus prefab to spawn in the Unity editor.");
                return;
            }

            // Spawn the Wumpus in each room
            GameObject spawnedWumpus = Instantiate(Wumpus, spawnPos, Quaternion.identity);

            // Optionally, you can perform additional operations on the spawned Wumpus
            // For example, you might want to set its parent to the room
            // spawnedWumpus.transform.SetParent(room.transform);
        }
    }

    void SpawnRandomGameObjects()
    {
        // Check if there are objects to spawn and a prefab is assigned
        List<int> selectedRoomIndices = new List<int>();

        // Spawn Wumpus
        SpawnObjectInRandomRoom(WumpusPrefab, selectedRoomIndices);

        // Spawn Bat
        SpawnObjectInRandomRoom(BatPrefab, selectedRoomIndices);

        // Spawn Pit
        SpawnObjectInRandomRoom(PitPrefab, selectedRoomIndices);

        // Spawn Player
        SpawnObjectInRandomRoom(PlayerPrefab, selectedRoomIndices);
    }

    void SpawnObjectInRandomRoom(GameObject prefab, List<int> selectedRoomIndices)
    {
        int randomIndex;

        // Choose a random index that has not been selected before
        do
        {
            randomIndex = Random.Range(0, Rooms.Length);
        } while (selectedRoomIndices.Contains(randomIndex));

        selectedRoomIndices.Add(randomIndex);

        // Get the position of the center of the chosen game object
        GameObject selectedRoom = Rooms[randomIndex];
        Vector3 spawnPos = selectedRoom.transform.position;

        if (prefab == null)
        {
            Debug.LogError("Prefab is not assigned. Please assign the prefab to spawn in the Unity editor.");
            return;
        }

        // Spawn the object in the center of the room
        GameObject spawnedObject = Instantiate(prefab, spawnPos, Quaternion.identity);

        // Optionally, you can perform additional operations on the spawned object
        // For example, you might want to set its parent to the chosen game object
        // spawnedObject.transform.SetParent(selectedRoom.transform);
    }
}
