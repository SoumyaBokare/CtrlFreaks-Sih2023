using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerfollow : MonoBehaviour
{

    public Transform targetObject;

    public Vector3 cameraoffset;
    // Start is called before the first frame update
    void Start()
    {
        cameraoffset = transform.position - targetObject.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newPosition = targetObject.transform.position + cameraoffset;
        transform.position = newPosition;
    }
}
