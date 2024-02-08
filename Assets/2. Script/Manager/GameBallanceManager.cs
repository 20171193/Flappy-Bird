using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBallanceManager : MonoBehaviour
{
    [Header("")]
    [Space(30)]

    [Header("화면 이동 속도")]
    [SerializeField]
    float schrollSpeed;
    public float SchrollSpeed { set { schrollSpeed = value;  }  get { return schrollSpeed; } }


    [Header("장애물 간격")]
    [SerializeField]
    float obstacleInterval;
    public float ObstacleInterval { set { obstacleInterval = value; } get { return obstacleInterval; } }

    [Header("플레이어 점프 속도")]
    [SerializeField]
    float jumpSpeed;
    public float JumpSpeed { set { jumpSpeed = value;} get { return jumpSpeed; } }

}
