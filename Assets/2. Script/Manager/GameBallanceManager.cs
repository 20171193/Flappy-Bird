using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBallanceManager : MonoBehaviour
{
    [Header("")]
    [Space(30)]

    [Header("ȭ�� �̵� �ӵ�")]
    [SerializeField]
    float schrollSpeed;
    public float SchrollSpeed { set { schrollSpeed = value;  }  get { return schrollSpeed; } }


    [Header("��ֹ� ����")]
    [SerializeField]
    float obstacleInterval;
    public float ObstacleInterval { set { obstacleInterval = value; } get { return obstacleInterval; } }

    [Header("�÷��̾� ���� �ӵ�")]
    [SerializeField]
    float jumpSpeed;
    public float JumpSpeed { set { jumpSpeed = value;} get { return jumpSpeed; } }

}
