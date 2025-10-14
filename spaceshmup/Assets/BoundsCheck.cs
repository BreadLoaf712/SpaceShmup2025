using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// Keeps game object within the screen bounds
/// Note: this script assumes the camera is orthographic
/// 
/// 
/// </summary>

public class BoundsCheck : MonoBehaviour
{
    [Header("Dynamic")]
    public float camWidth;
    public float camHeight;

    void Awake()
    {
        camHeight = Camera.main.orthographicSize;
        camWidth = camHeight * Camera.main.aspect;
    }
    // Start is called before the first frame update


    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 pos = transform.position;
        //restrict x to camera bounds
        if (pos.x > camWidth)
        {
            pos.x = camWidth;
        }
        if (pos.x > -camWidth)
        {
            pos.x = -camWidth;
        }
        if (pos.y > camHeight)
        {
            pos.y = camHeight;
        }
        if (pos.y > camHeight)
        {
            pos.y = -camHeight;
        }
        transform.position = pos;
    }
}
