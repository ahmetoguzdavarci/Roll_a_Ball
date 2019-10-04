using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera_kontrol : MonoBehaviour
{
    public GameObject top;  //topun pozisyonun a ulaşmak için bir nesne ürettik. Bu nesnenin içine panelden topu sürükleyip bıraktık.

    Vector3 aradaki_mesafe; //kamerayla top arasındaki mesafeyi hesaplamak için ihtiyacımız olan nesne.

    void Start()
    {
        aradaki_mesafe = transform.position - top.transform.position;   //kameranın içinde olduğumuz için o nesneyi yazmamıza gerek kalmadı.
        
    }

   
    void LateUpdate()
    {
        transform.position = top.transform.position + aradaki_mesafe;   //kameranın aradaki mesafe uzaklığından takip etmesi için.
    }
}
