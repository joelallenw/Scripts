using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
   // public GameObject plane;
    //private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {

    }
public GameObject player;
private Vector3 offset = new Vector3(30,5.5f,4.5f);
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;

    }
}
