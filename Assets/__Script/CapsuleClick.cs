﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "TheCapsule"){
                    Debug.Log("Capsule is clicked by mouse");
                    gameObject.transform.position = new Vector3(-1, 4f, 0);
                }
            }
        }
    }
}
