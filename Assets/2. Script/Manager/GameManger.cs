using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour
{
    #region Singleton Method
    private static GameManger instance = null;

    [SerializeField]
    GameBallanceManager ballanceManager;    // Game ballance changer
    public static GameBallanceManager Ballance { get { return instance.ballanceManager; } }

    [SerializeField]
    ObjectPoolManager objectPoolManager;    // Obstacle object pool
    public static ObjectPoolManager ObjectPool { get { return instance.objectPoolManager; } }

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
