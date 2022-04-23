using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Table_Input : MonoBehaviour
{
    public string Number;
    public GameObject inputField;

    public void StoreNumber()
    {
        Number = inputField.GetComponent<Text>().text;
    }
}
