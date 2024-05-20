using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addition_subtraction_vectors: MonoBehaviour{
    
    [SerializeField] Vector3 sum_position, subtraction_position;
    [SerializeField] Transform objective;

    void Update(){
        //sum
        if(Input.GetKey(KeyCode.Space)){
            transform.position+=sum_position;
        }

        //subtraction
        if(Input.GetKey(KeyCode.KeypadEnter)) {
            transform.position-=subtraction_position;
        }

        print("Magnitud "+(transform.position-objective.position).magnitude);
    }
}
