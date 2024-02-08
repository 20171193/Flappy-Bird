using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdater : MonoBehaviour
{
    [Header("�޴� �̹���")]
    [SerializeField]
    Image targetImage;

    [Header("��, ��, �� ��������Ʈ")]
    [SerializeField]
    Sprite[] medalSprites;

    [Header("���ھ� �ؽ�Ʈ")]
    [SerializeField]
    TextMeshProUGUI textMeshProUGUI;

    private void Start()
    {
        GameManger.Ballance.OnEarnedScore += UpdateScore;
    }

    public void UpdateScore(int value)
    {
        Debug.Log("���ھ� ������Ʈ");

        if (value < 10)
        {
            if (targetImage.sprite != medalSprites[0])
                targetImage.sprite = medalSprites[0];
        }
        else if (value < 20)
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
