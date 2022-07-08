using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCube : MonoBehaviour
{
    [SerializeField] float ForwardSpeed;
    [SerializeField] float HorizontalSpeed;
    public VariableJoystick variableJoystick;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal")*HorizontalSpeed*Time.deltaTime;
        float HorizontalMobile = variableJoystick.Horizontal*HorizontalSpeed*Time.deltaTime;

        this.transform.Translate(Horizontal,0, ForwardSpeed * Time.deltaTime);
        //this.transform.Translate(HorizontalMobile,0, ForwardSpeed * Time.deltaTime);

    }
}
