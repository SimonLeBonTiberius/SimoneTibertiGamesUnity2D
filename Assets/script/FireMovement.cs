using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMovement : MonoBehaviour{
    public Transform trans;
    
        void Update(){
          if (Input.GetButtonDown("LookUp")) {
            if ( Input.GetButtonDown("Horizontal") | Input.GetButton("Horizontal")){
                trans.Rotate( 0f, 0f , 45f);
                
            }
            else
            {
                trans.Rotate(0f, 0f, 90f);
                Debug.Log("Im' looking up");
            }
            }
           
        if (Input.GetButtonUp("LookUp") && trans.localRotation == Quaternion.Euler(0f, 0f, 45f))
        {
            trans.Rotate(0f, 0f, -45f);
            Debug.Log("Botton LookUp and 45°");
        } else if (Input.GetButtonUp("LookUp") && trans.localRotation == Quaternion.Euler(0f, 0f, 90f)) {
            trans.Rotate(0f, 0f, -90f);
            Debug.Log("Botton LookUp and 90°");
        }

        /*else if(Input.GetButtonUp("LookUp")) { trans.Rotate(0f, 0f, -45f);
            Debug.Log("Non je la famo");
        }*/
        
    }
}
