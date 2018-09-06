using System.Collections;
using System.Collections.Generic;

using UnityEngine;
public class Compass : MonoBehaviour
{
    private Quaternion MissionDirection;
    private Transform Arrow;
    private Transform Missionplace;

    void Start()
    {
        Arrow = GameObject.FindGameObjectWithTag("Arrow").GetComponent<Transform>();
        Missionplace = GameObject.FindGameObjectWithTag("Goal").GetComponent<Transform>();
    }

    void Update()
    {
        ChangeMissionDirection();
    }
    void ChangeMissionDirection()
    {
        Vector3 dir = Arrow.position - Missionplace.position;
        MissionDirection = Quaternion.LookRotation(dir);
        MissionDirection.z = -MissionDirection.x;
        MissionDirection.x = 0;
        MissionDirection.y = 0;
        Arrow.rotation = MissionDirection;
        transform.Rotate(0, 0, 90);
    }
}