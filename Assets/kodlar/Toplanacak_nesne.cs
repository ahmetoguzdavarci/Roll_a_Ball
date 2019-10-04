using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toplanacak_nesne : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45)*Time.deltaTime);   //nesneyi döndürmek için kullanılan fonksiyondur.
    }
}
