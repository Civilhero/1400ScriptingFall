using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Single Variable/Floatybehave")]
public class Floatybehave : ScriptableObject
{
    public float value;

    public void UpdateValue(float amount)
    {
        value += amount;
    }

    public void Setvalue(float amount)
    {
        value = amount;
    }
}
