using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputHolder : MonoBehaviour
{
    [SerializeField] InputField inputField;

    public void ValidateInput()
    {
        string input = inputField.text;
    }
}
