using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 inputDir = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        Vector2 realDir = Camera.main.transform.TransformDirection(inputDir);
        if(realDir.magnitude > 0.1f)
            {
                Quaternion newRotation = Quaternion.LookRotation(realDir);
                transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, Time.deltaTime * 10);
            }
    }
}
