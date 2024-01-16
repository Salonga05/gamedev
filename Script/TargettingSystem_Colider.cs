using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargettingSystem_Colider : MonoBehaviour
{
  public GameObject bullet;
  public Transform bulletPos; 
   


  private float timer;
  private void OnTriggerEnter2D(Collider2D collision){
   
}
void Update(){
  timer += Time.deltaTime;


  if (timer > 2){
    timer = 0;
    shoot(); 
  }
}

void shoot()
{
  Instantiate(bullet, bulletPos.position, Quaternion.identity);
}
}
