using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPressedSE : MonoBehaviour
{
    [SerializeField] AudioSource aus;
    [SerializeField] AudioClip se;
    public void OnClickButton()
    {
        aus.PlayOneShot(se);
    }
}
