using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject Target;
    public Vector3 distance;
    void Start()
    {

    }

    private void LateUpdate()
    {
        this.transform.position = Vector3.Lerp(this.transform.position, Target.transform.position + distance, Time.deltaTime*10f);
    }
}
