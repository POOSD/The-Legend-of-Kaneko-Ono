using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
   public GameObject playerObject;  // the player object to follow
   public float lerpSpeed = 0.5f;
   public Vector3 offset;
 
    void Start() {
        // get the current offset between player and camarea positions
        offset = transform.position + playerObject.transform.position;
    }
 
    void LateUpdate() {
         //transform.position = Vector3.Lerp(
         //   transform.position.x,                         // current camera position
         //   offset,                                       // new position plus our original offset
         //   lerpSpeed);                                   // the speed of smoothing

         transform.position = Vector3.Lerp(
            transform.position,                         // Vector3 A
            offset,                                       // Vector3 B
            lerpSpeed);                                   // float
    }
}