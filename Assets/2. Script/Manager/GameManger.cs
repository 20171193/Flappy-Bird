using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour
{
    #region Singleton Method
    private static GameManger instance = null;

    [SerializeField]
    GameBallanceManager ballanceManager;    // game ballance changer
    public static GameBallanceManager Ballance { get { return instance.ballanceManager; } }

    [SerializeField]
    ObjectPoolManager objectPoolManager;    // obstacle object pool
    public static ObjectPoolManager ObjectPool { get { return instance.objectPoolManager; } }

    [SerializeField]
    GameFlowManager flowManger;             // overall game flow management   
    public static GameFlowManager GameFlow { get { return instance.flowManger; } } 

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    public static GameManger Instance
    {
        get
        {
            if (instance == null)
                return null;
            else
                return instance;
        }
    }
    #endregion
}
