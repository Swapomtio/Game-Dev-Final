using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class mapGeneration : MonoBehaviour
{
    [SerializeField] GameObject[] Rooms;
    [SerializeField] GameObject WumpusPrefab;
    [SerializeField] GameObject BatPrefab;
    [SerializeField] GameObject PitPrefab;
    //[SerializeField] GameObject PlayerPrefab;
    [SerializeField] GameObject heartDrops;
    [SerializeField] GameObject arrowDrops;
    List<int> selectedRoomIndices;

    void Start()
    {
        Rooms = GameObject.FindGameObjectsWithTag("room");

        // Example: Print the names of the rooms
        if (Rooms.Length == 0)
        {
            Debug.LogError("No game objects in the array. Please assign game objects in the Unity editor.");
            return;
        }
        SpawnRandomGameObjects();
        //SpawnWumpusInAllRooms(WumpusPrefab);
    }
    void SpawnWumpusInAllRooms(GameObject Wumpus)
    {
        foreach (GameObject room in Rooms)
        {
            // Get the position of the center of the child object called "square"
            Transform squareTransform = room.transform.Find("Square");
            
            if (squareTransform == null)
            {
                Debug.LogError("The child object 'square' not found in the room. Make sure it exists and has the correct name.");
                return;
            }

            Vector3 spawnPos = squareTransform.position - new Vector3(0, 1f, 0);

            if (Wumpus == null)
            {
                Debug.LogError("Wumpus prefab is not assigned. Please assign the Wumpus prefab to spawn in the Unity editor.");
                return;
            }

            // Spawn the Wumpus in each room
            GameObject spawnedWumpus = Instantiate(Wumpus, spawnPos, Quaternion.identity);

        }
    }

    void SpawnRandomGameObjects()
    {
        // Check if there are objects to spawn and a prefab is assigned
        selectedRoomIndices = new List<int>();

        // Spawn Wumpus
        SpawnObjectInRandomRoom(WumpusPrefab, selectedRoomIndices);

        // Spawn Bat
        SpawnObjectInRandomRoom(BatPrefab, selectedRoomIndices);

        // Spawn Pit
        SpawnObjectInRandomRoom(PitPrefab, selectedRoomIndices);

        // Spawn Player
        //SpawnObjectInRandomRoom(PlayerPrefab, selectedRoomIndices);

        SpawnObjectInRandomRoom(heartDrops, selectedRoomIndices);

        SpawnObjectInRandomRoom(arrowDrops, selectedRoomIndices);
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

        // Get the position of the center of the child object called "square"
        Transform squareTransform = selectedRoom.transform.Find("Square");

        if (squareTransform == null)
        {
            Debug.LogError("The child object 'square' not found in the room. Make sure it exists and has the correct name.");
            return;
        }

        Vector3 spawnPos = squareTransform.position - new Vector3(0, 1f, 0);

        if (prefab == null)
        {
            Debug.LogError("Prefab is not assigned. Please assign the prefab to spawn in the Unity editor.");
            return;
        }

        // Spawn the object in the center of the room
        GameObject spawnedObject = Instantiate(prefab, spawnPos, Quaternion.identity);

    }
}
