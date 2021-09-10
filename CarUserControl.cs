using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use


        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }


        private void FixedUpdate()
        {
            // pass the input to the car!
            float h = CrossPlatformInputManager.GetAxis("Steering");
            float v = CrossPlatformInputManager.GetAxis("Throttle");
            float r = CrossPlatformInputManager.GetAxis("Brake");

            
            //Added input for Reverse
#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            float rgear = CrossPlatformInputManager.GetAxis("Reverse");
            float ugear = CrossPlatformInputManager.GetAxis("UpGear");
            float dgear = CrossPlatformInputManager.GetAxis("DownGear");
            m_Car.Move(h, v, r, handbrake, rgear, ugear, dgear);
#else
            m_Car.Move(h, v, r, 0f, rgear, 0,0);
#endif
        }
    }
}
