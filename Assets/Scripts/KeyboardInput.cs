using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JPBC
{
    public class KeyboardInput : MonoBehaviour
    {
        protected string[] KeyItem = { "1", "2", "3", "4", "5", "6", "7" };
        private bool GotInput = false;
        // Update is called once per frame
        void Update()
        {

            /*if(Input.GetKey(KeyCode.D))
            {
                ControlManager.Instance.Right = true;
            } else
            {
                ControlManager.Instance.Right = false;
            }

            if (Input.GetKey(KeyCode.A))
            {
                ControlManager.Instance.Left = true;
            }
            else
            {
                ControlManager.Instance.Left = false;
            }


            return;*/

            if (Input.anyKey)
            {
                GotInput = true;
                //Right
                ControlManager.Instance.Right = Input.GetKey(KeyCode.D) ? true : false;
                //Left
                ControlManager.Instance.Left = Input.GetKey(KeyCode.A) ? true : false;
                //Forward
                ControlManager.Instance.Forward = Input.GetKey(KeyCode.W) ? true : false;
                //Backward
                ControlManager.Instance.Backward = Input.GetKey(KeyCode.S) ? true : false;
                //Space
                ControlManager.Instance.Space = Input.GetKey(KeyCode.Space) ? true : false;

                KeyItemChecking(KeyItem);
            } else if (GotInput)
            {
                ControlManager.Instance.ResetControllerVar();
                GotInput = false;
            }
        }

        protected void KeyItemChecking(string[] StrArr)
        {
            for (int i = 0; i < StrArr.Length; i++)
            {
                ControlManager.Instance.KeyItem[1] = Input.GetKey(StrArr[i]) ? true : false;
            }
        }
    }
}
