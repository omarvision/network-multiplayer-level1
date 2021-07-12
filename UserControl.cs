using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UserControl : MonoBehaviour
{
    public float MoveSpeed = 3.5f;
    public float TurnSpeed = 120.0f;

    private void Update()
    {
        float vert = Input.GetAxis("Vertical");     // -1 .. 1
        float horz = Input.GetAxis("Horizontal");
        this.transform.Translate(Vector3.forward * vert * MoveSpeed * Time.deltaTime);
        this.transform.localRotation *= Quaternion.AngleAxis(horz * TurnSpeed * Time.deltaTime, Vector3.up);
    }
}