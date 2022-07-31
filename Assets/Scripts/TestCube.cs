using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JPBC
{
    public class TestCube : MonoBehaviour
    {
        public float Speed;
        public float JumpSpeed;
        public float GravityScale;


        private bool onGround;
        // Init rotation , (0,0,0);
        private bool OriginRotations = true;
        private Rigidbody rb;

        private void Start()
        {
            
            onGround = false;
            rb = this.gameObject.GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {
            if (ControlManager.Instance.Left && ControlManager.Instance.Right)
            {
                return;
            }

            if(ControlManager.Instance.Forward && ControlManager.Instance.Backward)
            {
                return;
            }

            if (ControlManager.Instance.Right)
            {
                this.gameObject.transform.Translate(Vector3.right * Speed * Time.deltaTime);
                this.gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                OriginRotations = true;
            }

            if (ControlManager.Instance.Left)
            {
                this.gameObject.transform.Translate(Vector3.right * Speed * Time.deltaTime);
                this.gameObject.transform.rotation = Quaternion.Euler(0f, -180f, 0f);
                OriginRotations = false;
            }
            
            if (ControlManager.Instance.Forward)
            {
                this.gameObject.transform.Translate(ObjectFace(OriginRotations) * Speed * Time.deltaTime);
            }

            if (ControlManager.Instance.Backward)
            {
                this.gameObject.transform.Translate(ObjectFace(!OriginRotations) * Speed * Time.deltaTime);
            }

            if (ControlManager.Instance.Space && onGround)
            {
                rb.AddForce(Vector3.up * JumpSpeed,ForceMode.Impulse);
                onGround = false;
            }
        }

        private void OnCollisionEnter(Collision collision)
        {
            if(collision.gameObject.tag == "Ground")
            {
                onGround = true;
            }
        }

        private Vector3 ObjectFace (bool item)
        {
            return item ? Vector3.forward : Vector3.back;
        }

        private void FixedUpdate()
        {
            rb.AddForce(Physics.gravity * (GravityScale - 1) * rb.mass);
        }
    }
}

