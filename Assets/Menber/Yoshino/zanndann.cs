using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class zanndann : MonoBehaviour
{
    //•Ï”‚ğ’eŠÇ—‚Ì•Ï”‚Æ•R‚Ã‚¯‚¢‚Ä‚­‚¾‚³‚¢
    private int zandan;
    public Text ZandanText;
    // Start is called before the first frame update
    void Start()
    {
        zandan = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ZandanText.text = zandan.ToString();
        if(Input.GetKeyDown(KeyCode.Space)) 
        { 
          zandan++;
        }
    }
}
