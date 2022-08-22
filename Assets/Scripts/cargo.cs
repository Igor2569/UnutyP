using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cargo : MonoBehaviour
{
    public Transform wheel_fl;
    public Transform wheel_fr;
    public Transform wheel_bl;
    public Transform wheel_br;
    public WheelCollider collider_fl;
    public WheelCollider collider_fr;
    public WheelCollider collider_bl;
    public WheelCollider collider_br;
    public float speed;
    public float maxugol;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        collider_fl.motorTorque = Input.GetAxis("Vertical") * speed*Time.fixedDeltaTime;
        collider_fr.motorTorque = Input.GetAxis("Vertical") * speed*Time.fixedDeltaTime;
        if (Input.GetKey(KeyCode.Space)){
            collider_fl.brakeTorque = 3000f;
            collider_fr.brakeTorque = 3000f;
            collider_bl.brakeTorque = 3000f;
            collider_br.brakeTorque = 3000f;
        }
        else
        {
            collider_fl.brakeTorque = 0f;
            collider_fr.brakeTorque = 0f;
            collider_bl.brakeTorque = 0f;
            collider_br.brakeTorque = 0f;
        }
        collider_fl.steerAngle = maxugol * Input.GetAxis("Horizontal")*Time.fixedDeltaTime;
        collider_fr.steerAngle = maxugol * Input.GetAxis("Horizontal")*Time.fixedDeltaTime;
        RotateWheel(collider_fl, wheel_fl);
        RotateWheel(collider_fr, wheel_fr);
        RotateWheel(collider_bl, wheel_bl);
        RotateWheel(collider_br, wheel_br);
    }
    private void RotateWheel(WheelCollider collider, Transform transform)
    {
        Vector3 position;
        Quaternion rotation;
        collider.GetWorldPose(out position , out rotation);
        transform.position = position;
        transform.rotation = rotation;
    }
}
