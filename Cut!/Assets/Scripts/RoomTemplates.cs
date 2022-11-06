using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTemplates : MonoBehaviour
{
    public GameObject[] bottomRooms;
    public GameObject[] topRooms;
    public GameObject[] leftRooms;
    public GameObject[] rightRooms;

    public GameObject closedRoom;
    public List<GameObject> rooms;

    public float waitTime;
    private bool spawnedBoss;
    public GameObject boss;

    void Update()
    {
        if(waitTime <= 0 && spawnedBoss == false)
        {
           if(rooms[rooms.Count-1].tag == "ClosedRoom")
           {
                Instantiate(boss,rooms[rooms.Count-2].transform.position, Quaternion.identity);
           }else{
                 Instantiate(boss,rooms[rooms.Count-1].transform.position, Quaternion.identity);
           }
          
           spawnedBoss = true;
        } else{
          waitTime -= Time.deltaTime;  
        }
    }
}
