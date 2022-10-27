using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propellerSpin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
public float propellerRotation = 3000f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * propellerRotation);
        //transform.Rotate(Vector3.positiveInfinity * propellerRotation * Time.deltaTime);
    }
}
