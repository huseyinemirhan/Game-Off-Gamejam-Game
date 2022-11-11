using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject chair;
    public GameObject lamp;
    void Start()
    {
        float ranx = Random.Range(-5,5);
        float rany = Random.Range(-5,5);
        float rano = Random.Range(1,2);
        if (rano == 1)
        {
            Instantiate(chair,new Vector2(this.transform.position.x + ranx,this.transform.position.y+rany), Quaternion.identity);
        } else if(rano == 2)
        {
             Instantiate(lamp,new Vector2(this.transform.position.x + ranx,this.transform.position.y+rany), Quaternion.identity);
        }
        
    }
   public GameObject[] Doors;
   void OnTriggerEnter2D(Collider2D other)
   {
    if(other.gameObject.tag == "Player")
    {
        Invoke("DoorClose",0.5f);
    }
    
    }
   

   private void DoorClose()
   {
        foreach(GameObject door in Doors) {
           door.SetActive(true);
         }

   }
}
