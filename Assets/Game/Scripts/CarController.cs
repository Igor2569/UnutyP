using System.Collections.Generic;

using UnityEngine;

namespace Game.Systems
{
    public class CarController : MonoBehaviour
    {
		public Rigidbody rigidbody;
		[Space]
        public Wheel wheelFL;
        public Wheel wheelFR;
        public Wheel wheelBL;
        public Wheel wheelBR;
		public float mass;
		public float maxMotorTorque;
        public float maxSteeringAngle;

		//public DriveType drive = DriveType.Rear;

		private List<Wheel> wheels = new List<Wheel>();

		private void Start()
		{
			wheels.Add(wheelFL);
			wheels.Add(wheelFR);
			wheels.Add(wheelBL);
			wheels.Add(wheelBR);
		}

		void FixedUpdate()
		{
			UpdateParams();

			foreach (var wheel in wheels)
			{
				if (wheel.isCanMotoring)
				{
					wheel.collider.motorTorque = Input.GetAxis("Vertical") * maxMotorTorque;
				}

				if (wheel.isCanSteering)
				{
					wheel.collider.steerAngle = Input.GetAxis("Horizontal") * maxSteeringAngle;
				}
			}

			if (Input.GetKey(KeyCode.Space))
			{
				SetBrakeTorque(9000);
			}
			else
			{
				SetBrakeTorque(0);
			}

			wheelFL.RotateWheel();
			wheelFR.RotateWheel();
			wheelBL.RotateWheel();
			wheelBR.RotateWheel();
		}

		private void UpdateParams()
		{
			rigidbody.mass = mass;
		}

		private void SetBrakeTorque(float value)
		{
			wheelFL.collider.brakeTorque = value;
			wheelFR.collider.brakeTorque = value;
			wheelBL.collider.brakeTorque = value;
			wheelBR.collider.brakeTorque = value;
		}

		[System.Serializable]
		public class Wheel
		{
			public Transform transform;
			public WheelCollider collider;
			public bool isCanMotoring;
			public bool isCanSteering;

			public void RotateWheel()
			{
				collider.GetWorldPose(out Vector3 position, out Quaternion rotation);
				transform.position = position;
				transform.rotation = rotation;
			}
		}

		public enum DriveType
		{
			Front,
			Rear,
			Full,
			Custom,
		}
	}
}