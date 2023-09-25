using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ArController_Dog2 : MonoBehaviour
{
     public GameObject MyObjectDog;
   public ARRaycastManager RaycastManager;

   private void Update()
   {
    if(Input.touchCount>0 && Input.GetTouch(0).phase==TouchPhase.Began){
        List<ARRaycastHit> touches = new List<ARRaycastHit>();
        RaycastManager.Raycast(Input.GetTouch(0).position, touches, UnityEngine.XR.ARSubsystems.TrackableType.Planes);

        if(touches.Count > 2)
        GameObject.Instantiate(MyObjectDog,touches[0].pose.position,touches[0].pose.rotation);
    }
   }
}
