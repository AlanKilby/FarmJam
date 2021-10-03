using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class AK_CinemachineChanger : MonoBehaviour
{
    CinemachineVirtualCamera vCam;

    private void Start()
    {
        vCam = GetComponent<CinemachineVirtualCamera>();
       
    }

    private void Update()
    {
        vCam.Follow = GameObject.FindGameObjectWithTag("Player").transform;
    }
}
