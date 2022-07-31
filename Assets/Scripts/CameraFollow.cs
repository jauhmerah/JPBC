using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JPBC
{
    public class CameraFollow : MonoBehaviour
    {
        public Transform Target;
        Vector3 Distance;
        public float SmoothValue;

        // Start is called before the first frame update
        void Start()
        {
            Distance = Target.position - transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            Follow();
        }

        void Follow()
        {
            Vector3 currentPos = transform.position;

            Vector3 targetPos = Target.position - Distance;

            // Kasi smooth movement camera
            transform.position = Vector3.Lerp(currentPos, targetPos, SmoothValue * Time.deltaTime);
        }
    }
}
