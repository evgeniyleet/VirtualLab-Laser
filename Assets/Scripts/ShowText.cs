using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowText : MonoBehaviour
{
    [SerializeField] GameObject HelpText;

    void Start()
    {
        HelpText.SetActive(false);
    }

    public void OnMouseOver()
    {
        HelpText.SetActive(true);
    }

    public void OnMouseExit()
    {
        HelpText.SetActive(false);
    }
}
