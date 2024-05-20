using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Product_scalar : MonoBehaviour{
    [Range(-1f,1f)]
    [SerializeField] float horizantal;
    [SerializeField] bool normalize;//normalize=normalizar
    [SerializeField] float speed;//speed=velocidad

    private void OnDrawGizmos(){
        Vector3 position=calculate_position();
        Gizmos.DrawLine(Vector3.zero,position);
        Gizmos.DrawSphere(position, 0.07f);
    }

    private Vector3 calculate_position(){
        Vector3 position=Vector3.forward;
        position.x = horizantal;

        if(normalize) {
            position.Normalize();
        }

        return position*speed;
    }
}
