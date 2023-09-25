using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARController_Dog : MonoBehaviour
{
    public GameObject MyObjectDog;
   public ARRaycastManager RaycastManager;
   int dog = GameObject.FindGameObjectsWithTag("MyObjectDog").Length;

   private void Update()
   {
    if(Input.touchCount>0 && Input.GetTouch(0).phase==TouchPhase.Began){
        List<ARRaycastHit> touches = new List<ARRaycastHit>();
        RaycastManager.Raycast(Input.GetTouch(0).position, touches, UnityEngine.XR.ARSubsystems.TrackableType.Planes);

        if(touches.Count > 0 && dog < 1)
        GameObject.Instantiate(MyObjectDog,touches[0].pose.position,touches[0].pose.rotation);
    }
   }
}
