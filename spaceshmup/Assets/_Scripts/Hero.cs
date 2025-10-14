using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    static public Hero S { get; private set; } //singleton

    [Header("Inscribed")]
    public float speed = 30;
    public float rollMulti = -45;
    public float pitchMulti = 30;

    [Header("Dynamic")]
    [Range(0, 4)]
    public float shieldLevel = 1;

    private void Awake()
    {
        if(S == null)
        {
            S = this;
        }
        else
        {
            Debug.LogError("Hero.Awake()-Attempted to assign second Hero.S!");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis ("Vertical");

        Vector3 pos = transform.position;
        pos.x += hAxis * speed * Time.deltaTime;
        pos.y += vAxis * speed * Time.deltaTime;
        transform.position = pos;
        transform.rotation = Quaternion.Euler(vAxis * pitchMulti, hAxis * rollMulti, 0);

    }
}
