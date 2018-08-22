using System.Collections;
using System.Collections.Generic;

using Cinemachine;

using UnityEngine;

public class cinemachine : MonoBehaviour
{

    CinemachineVirtualCamera vcam;

    // Use this for initialization
    void Start()
    {
        vcam = GetComponent<CinemachineVirtualCamera>();
        vcam.m_Follow = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {

    }
}