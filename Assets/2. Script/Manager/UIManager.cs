using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    #region Singleton Method
    private static UIManager instance = null;

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
    public static UIManager Instance
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

    [Header("메달 이미지")]
    [SerializeField]
    Image targetImage;

    [Header("금, 은, 동 스프라이트")]
    [SerializeField]
    Sprite[] medalSprites;

    [Header("스코어 텍스트")]
    [SerializeField]
    TextMeshProUGUI textMeshProUGUI;

    private void Start()
    {
        GameManger.Ballance.OnEarnedScore += UpdateScore;
    }

    public void UpdateScore(int value)
    {
        Debug.Log("스코어 업데이트");

        if(value < 100)
        {
            if(targetImage.sprite != medalSprites[0])
                targetImage.sprite = medalSprites[0];   
        }
        else if(value < 200)
        {
            if (targetImage.sprite != medalSprites[1])
                targetImage.sprite = medalSprites[1];
        }
        else
        {
            if (targetImage.sprite != medalSprites[2])
                targetImage.sprite = medalSprites[2];
        }

        textMeshProUGUI.text = value.ToString();
    }
}
