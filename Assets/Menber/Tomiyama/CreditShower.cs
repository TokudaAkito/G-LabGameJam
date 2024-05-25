using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditShower : MonoBehaviour
{
    [SerializeField] GameObject titleText;
    [SerializeField] GameObject CreditPanel;
    public void OnClick()
    {
        titleText.SetActive(false);
        CreditPanel.SetActive(true);
    }

    public void OnClickBack()
    {
        titleText.SetActive(true);
        CreditPanel.SetActive(false);
    }
}
