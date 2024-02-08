using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PreferenceManager : MonoBehaviour
{
    [Header("Resolution")]
    [SerializeField]
    Vector2 resolution;
    Vector2 Resolution { get { return resolution; } }


    [Header("Bottom Ground DeltaSize")]
    [SerializeField]
    Vector2 groundSize;
    Vector2 GroundSize { get { return groundSize; } }


    private void Start()
    {
        resolution = GameObject.FindWithTag("BackGround").GetComponent<RectTransform>().sizeDelta;
        groundSize = GameObject.FindWithTag("BottomGround").GetComponent<RectTransform>().sizeDelta;
    }
}
