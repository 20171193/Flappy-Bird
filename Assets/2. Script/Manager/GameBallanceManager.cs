using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameBallanceManager : MonoBehaviour
{
    [Header("")]
    [Space(30)]
    [Header("���� ���̵� ���� (����� ������ ����)")]
    [SerializeField]
    int ballanceValue;
    public int BallanceValue { set { ballanceValue = value; } get { return ballanceValue; } }

    private int curBallanceValue;


    [Header("���� ���� �ӵ�")]
    [SerializeField]
    float gameSpeed;
    public float GameSpeed { set { gameSpeed = value;  }  get { return gameSpeed; } }

    [Header("��ֹ� ����")]
    [SerializeField]
    float obstacleSpawnTime;
    public float ObstacleSpawnTime { set { obstacleSpawnTime = value; } get { return obstacleSpawnTime; } }

    [Header("�÷��̾� ���� �ӵ�")]
    [SerializeField]
    float jumpSpeed;
    public float JumpSpeed { set { jumpSpeed = value;} get { return jumpSpeed; } }

    [Header("���� ���ھ�")]
    [SerializeField]
    int gameScore;
    public int GameScore { set { gameScore = value; } get { return gameScore; } }
    public UnityAction<int> OnEarnedScore;

    [Header("ȹ���ϴ� ���ھ�")]
    [SerializeField]
    int earnScore;
    public int EarnScore { set { earnScore = value; } get { return earnScore; } }

    // ȹ�� ���ھ� ó��
    public void GetScore()
    {
        gameScore += earnScore;
        curBallanceValue++;
        if(curBallanceValue >= ballanceValue)
        {
            curBallanceValue = 0;
            earnScore *= 2;         // ȹ�� ���ھ� ������Ʈ
            gameSpeed += 0.2f;      // ���� �ӵ� ������Ʈ
        }
        // UI ������Ʈ (���� ���ھ�, ���� �ӵ�)
        OnEarnedScore?.Invoke(gameScore);
    }
}
