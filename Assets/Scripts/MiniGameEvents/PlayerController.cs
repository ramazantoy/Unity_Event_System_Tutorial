using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float _movementSpeed;


    [SerializeField]
    private Vector3 _movementMaxClamps;
    [SerializeField]
    private Vector3 _movementMinClamps;
    
    void Update()
    {
        Vector3 currentPos = transform.position;

        if (Input.GetKey(KeyCode.A))
        {
            currentPos += Vector3.left * _movementSpeed * Time.deltaTime;
        }
        
        if (Input.GetKey(KeyCode.D))
        {   
            currentPos += Vector3.right * _movementSpeed * Time.deltaTime;
        }
        
        if (Input.GetKey(KeyCode.W))
        {   
            currentPos += Vector3.forward * _movementSpeed * Time.deltaTime;
        }
        
        if (Input.GetKey(KeyCode.S))
        {   
            currentPos += -Vector3.forward * _movementSpeed * Time.deltaTime;
        }
        
        currentPos.x = Mathf.Clamp(currentPos.x, _movementMinClamps.x, _movementMaxClamps.x);
        currentPos.z = Mathf.Clamp(currentPos.z, _movementMinClamps.z, _movementMaxClamps.z);
        
        transform.position = currentPos;
    }
}
