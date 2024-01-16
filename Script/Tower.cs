using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    private Vector3 projectileShootFromPosition; 


    private void Awake(){

        projectileShootFromPosition = transform.Find("ProjectileShootPosition").position;
    }

    private void Update(){
        if (Input.GetMouseButtonDown(0)){
            Debug.Log("Clicked"); 
        }
    }
}
