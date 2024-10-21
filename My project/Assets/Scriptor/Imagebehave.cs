using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class Imagebehave : MonoBehaviour
{
    private Image ImageObj;
    public Floatybehave dataObject;
    private void Start()
    {
        ImageObj = GetComponent<Image>();
    }

    public void UpdateWithFloatybeave()
    {
        ImageObj.fillAmount = dataObject.value;
    }
}
