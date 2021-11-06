using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Pathfindingscript : MonoBehaviour
{

    public NavMeshAgent PlayerAI;
    public Camera Playercamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            //Ray  shoots from mouse position
            Ray Raysfromcamera = Playercamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit Hitraycast;
            if(Physics.Raycast(Raysfromcamera, out Hitraycast))
            {
                //Assigns the destination to the hitpoint
                PlayerAI.SetDestination(Hitraycast.point);
            }


            
         }
    }
}
