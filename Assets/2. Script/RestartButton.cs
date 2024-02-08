using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public void OnClickRestartButton()
    {
        SceneManager.LoadScene("MainGameScene");
    }
}
