using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector_vormalization : MonoBehaviour{
    [SerializeField] float speed;

    void Update(){
        Vector3 position=Vector3.zero;

        if(Input.GetKey(KeyCode.UpArrow)){
            position.z=1;
        }else{
            if(Input.GetKey(KeyCode.DownArrow)) {
                position.z=-1;
            }
        }

        if(Input.GetKey(KeyCode.RightArrow)) {
            position.x=1;
        } else {
            if(Input.GetKey(KeyCode.LeftArrow)) {
                position.x=-1;
            }
        }

        transform.position=transform.position+position.normalized*speed;
    }
}
