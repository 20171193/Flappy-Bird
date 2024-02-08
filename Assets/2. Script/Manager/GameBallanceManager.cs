using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameBallanceManager : MonoBehaviour
{
    [Header("")]
    [Space(30)]
    [Header("게임 난이도 설정 (통과한 파이프 개수)")]
    [SerializeField]
    int ballanceValue;
    public int BallanceValue { set { ballanceValue = value; } get { return ballanceValue; } }

    private int curBallanceValue;


    [Header("게임 진행 속도")]
    [SerializeField]
    float gameSpeed;
    public float GameSpeed { set { gameSpeed = value;  }  get { return gameSpeed; } }

    [Header("장애물 간격")]
    [SerializeField]
    float obstacleSpawnTime;
    public float ObstacleSpawnTime { set { obstacleSpawnTime = value; } get { return obstacleSpawnTime; } }

    [Header("플레이어 점프 속도")]
    [SerializeField]
    float jumpSpeed;
    public float JumpSpeed { set { jumpSpeed = value;} get { return jumpSpeed; } }

    [Header("게임 스코어")]
    [SerializeField]
    int gameScore;
    public int GameScore { set { gameScore = value; } get { return gameScore; } }
    public UnityAction<int> OnEarnedScore;

    [Header("획득하는 스코어")]
    [SerializeField]
    int earnScore;
    public int EarnScore { set { earnScore = value; } get { return earnScore; } }

    // 획득 스코어 처리
    public void GetScore()
    {
        gameScore += earnScore;
        curBallanceValue++;
        if(curBallanceValue >= ballanceValue)
        {
            curBallanceValue = 0;
            earnScore *= 2;         // 획득 스코어 업데이트
            gameSpeed += 0.2f;      // 게임 속도 업데이트
        }
        // UI 업데이트 (현재 스코어, 게임 속도)
        OnEarnedScore?.Invoke(gameScore);
    }
}
