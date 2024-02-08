using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSchrolling : MonoBehaviour
{
    [Header("References")]
    [Space(10)]

    [Header("BackGround Array")]
    [SerializeField]
    RectTransform[] backGrounds;

    [Header("Ground Array")]
    [SerializeField] 
    RectTransform[] grounds;

    [Header("Minimum X offset")]
    [SerializeField] 
    float minOffset;

    private void Update()
    {
        for(int i =0; i< grounds.Length; i++)
        {
            grounds[i].Translate(Vector3.left * GameManger.Ballance.GameSpeed * 3f * Time.deltaTime);
            if (grounds[i].anchoredPosition.x < minOffset)
            {
                grounds[i].anchoredPosition =
                    new Vector2(
                        grounds[(i + 2) % grounds.Length].anchoredPosition.x + grounds[i].sizeDelta.x - 50f,
                        grounds[i].anchoredPosition.y
                        );
            }   

            backGrounds[i].Translate(Vector3.left * GameManger.Ballance.GameSpeed * Time.deltaTime);
            if (backGrounds[i].anchoredPosition.x < minOffset)
            {
                backGrounds[i].anchoredPosition = 
                    new Vector2(
                        backGrounds[(i + 2) % backGrounds.Length].anchoredPosition.x + backGrounds[i].sizeDelta.x - 50f,
                        backGrounds[i].anchoredPosition.y
                        );
            }
        }
    }

    public void UpdatePosition()
    {

    }
}
