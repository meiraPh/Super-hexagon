using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{ 
    public GameObject stick;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButton(0) ) {
            
            Vector3 v = stick.transform.localScale;
            v.y = v.y + 0.07f;
            stick.transform.localScale = v;
        }

        if (Input.GetMouseButtonUp(0) ) {
            
            var rotationVector = stick.transform.rotation.eulerAngles;
            rotationVector.z = 90;
            stick.transform.rotation = Quaternion.Euler(rotationVector);
        }

    }

}
