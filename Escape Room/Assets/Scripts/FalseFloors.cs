using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace InfoGamer
{
    public class FalseFloors : MonoBehaviour
    {
        bool isFalse;
        [SerializeField] string playerTag;
        Renderer myRend;
        [SerializeField] FalseFloors[] group;
        Rigidbody myRB;
        [SerializeField] bool revealPath;
        private void OnEnable()
        {
            myRend = GetComponent<Renderer>();
            myRB = GetComponent<Rigidbody>();
        }
        // Start is called before the first frame update
        void Start()
        {
            if (group.Length == 0)
                return;
            int pathIndex = Random.Range(0, group.Length);
            for (int i = 0; i < group.Length; i++)
            {
                if (pathIndex == i)
                {
                    group[i].SetPath();
                }
                else
                {
                    group[i].SetFalsePath();
                }
            }
        }
        public void SetPath()
        {
            isFalse = false;
            myRB.isKinematic = true;
            if (revealPath)
            {
                myRend.material.SetColor("Color_EAB33CC2", Color.green);
            }
        }
        public void SetFalsePath()
        {
            isFalse = true;
            myRB.isKinematic = false;
            if (revealPath)
            {
                GetComponent<Rigidbody>().useGravity = true;

            }
        }
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.transform.tag == playerTag)
            {
                if (isFalse)
                {
                    GetComponent<Rigidbody>().useGravity = true;

                }
                else
                {
                    myRend.material.SetColor("Color_EAB33CC2", Color.green);
                }
            }
        }
    }
}