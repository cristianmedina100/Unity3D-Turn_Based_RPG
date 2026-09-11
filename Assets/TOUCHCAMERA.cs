using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TOUCHCAMERA : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Unity.Cinemachine.CinemachineCore.GetInputAxis = gitAxis;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private float gitAxis(string axis)
    {
        return 0.01f;
    }
}
