using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position +=  new Vector3(1,1,transform.position.z)* moveSpeed * Time.deltaTime;


    }

    void OnCollisionEnter2D(Collision2D other)
    {
    Destroy(gameObject);
    }
}
