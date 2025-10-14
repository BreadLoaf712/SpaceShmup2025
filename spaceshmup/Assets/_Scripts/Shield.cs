using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    [Header("Inscribed")]
    public float rotationsPerSecond = 0.1f;

    [Header("Dynamic")]
    public int levelShown = 0;

    Material mat;

    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        //read current shield level from the hero singleton
        int currLevel = (int)Hero.S.shieldLevel;
        if (levelShown != currLevel) {
            levelShown = currLevel;
            //adjust the texture offset to display the correct shield level
            mat.mainTextureOffset = new Vector2(0.2f * levelShown, 0);

        }
        //rotate the shield a bit every fame in a time-based manner
        float rZ = -(rotationsPerSecond * Time.time * 360) % 360;
        transform.rotation = Quaternion.Euler(0, 0, rZ);
        

    }
}
