using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaw : MonoBehaviour{

    public float speed;
    private Waypoints Wpoints;
    private int waypointIndex;
    private Spaw _enemy;

    void Start(){
        Wpoints = GameObject.FindGameObjectWithTag("Waypoints").GetComponent<Waypoints>();
    }

    void Update(){
        transform.position = Vector2.MoveTowards(transform.position, Wpoints.waypoints[waypointIndex].position, speed * Time.deltaTime);

        if(Vector2.Distance(transform.position, Wpoints.waypoints[waypointIndex].position) < 0.1f){
            
            if(waypointIndex < Wpoints.waypoints.Length - 1){
                waypointIndex++;
            }else{
                Destroy(gameObject);
            }
        }
    }}

