using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;
public class PlayerAimWeapon : MonoBehaviour
{
   private Transform aimTransform;
   public GameObject bulletpf;
   public GameObject shootP;

   private void Awake() {
    aimTransform = transform.Find("Aim");
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
    Instantiate(bulletpf,shootP.transform.position,shootP.transform.rotation);
   }
}
