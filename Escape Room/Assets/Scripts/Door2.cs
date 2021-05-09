using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door2 : MonoBehaviour
{
    [SerializeField]
    GameObject target;
    [SerializeField]
    GameObject door;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            door.transform.position += new Vector3(0, -4, 0);
        }
    }
}
