using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Globalization;

[RequireComponent(typeof(TextMeshProUGUI))]
public class TextUpdater : MonoBehaviour
{
    private TextMeshProUGUI textObject;
    public Scoringbehave dataObject;

    private void Start()
    {
        textObject = GetComponent<TextMeshProUGUI>();
        UpdateWithIntData();
    }
    
    public void UpdateWithIntData()
    {
        textObject.text = dataObject.value.ToString(CultureInfo.InvariantCulture);
    }
}