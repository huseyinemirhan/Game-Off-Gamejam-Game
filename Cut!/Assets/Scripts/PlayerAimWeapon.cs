using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;
public class PlayerAimWeapon : MonoBehaviour
{
   private Transform aimTransform;
   public GameObject bulletpf;
   private Rigidbody2D rb;
   public Transform shootP;
   public float bulletSpeed = 100; 

   private void Awake() {
    aimTransform = transform.Find("Aim");
    rb = bulletpf.GetComponent<Rigidbody2D>();
   }

   private void Update() {
    Vector3 mousePos = UtilsClass.GetMouseWorldPosition();

    Vector3 aimDir = (mousePos - transform.position).normalized;
    float angle = Mathf.Atan2(aimDir.y, aimDir.x)   * Mathf.Rad2Deg;
    aimTransform.eulerAngles = new Vector3(0,0,angle);

    if(Input.GetMouseButtonDown(0))
    {
        Shoot();
    }


   }

   void Shoot()
   {
     GameObject bullet = Instantiate(bulletpf,shootP.position,shootP.rotation);
     bullet.GetComponent<Rigidbody2D>().AddForce(shootP.up * bulletSpeed, ForceMode2D.Impulse);

   }
}
