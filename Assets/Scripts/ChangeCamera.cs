using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ChangeCamera : MonoBehaviour
{
    public CinemachineVirtualCamera currentCamera;
    void Start()
    {
        // currentCamera.Priority++;
    }

    // Update is called once per frame
    public void UpdateCamera(CinemachineVirtualCamera target)
    {
      currentCamera.Priority--;

      currentCamera = target;

      currentCamera.Priority++;   
    }
}
