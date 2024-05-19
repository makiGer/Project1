using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class timeStop : MonoBehaviour
{
    public TextMeshProUGUI sourceTextMeshPro;
    public TextMeshProUGUI destinationTextMeshPro;

    void Start()
    {
        // Check if source and destination TMP components are assigned
        if (sourceTextMeshPro != null && destinationTextMeshPro != null)
        {
            // Copy text from source TMP to destination TMP
            destinationTextMeshPro.text = sourceTextMeshPro.text;
        }
        else
        {
            Debug.LogError("Source or destination TextMeshPro component is not assigned!");
        }
    }
}

