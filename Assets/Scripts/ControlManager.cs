using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JPBC
{
    public class ControlManager : MonoBehaviour
    {
        public static ControlManager Instance = null;
        
        public bool Left;
        public bool Right;
        public bool Forward;
        public bool Backward;
        public bool Space; // Jump;

        [Tooltip("Keyboard key 1 to 7")]
        public bool[] KeyItem;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            } else if (Instance != this)
            {
                Destroy(this.gameObject);
            }
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void ResetControllerVar ()
        {
            Left = false;
            Right = false;
            Forward = false;
            Backward = false;
            Space = false;

            for (int i = 0; i < KeyItem.Length; i++)
            {
                KeyItem[i] = false;
            }
        }
    }
}


