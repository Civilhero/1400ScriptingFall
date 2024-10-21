using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Single Variable/Scoringbehave")]
public class Scoringbehave : ScriptableObject
{
    public int value;

    public void UpdateValue(int amount)
    {
        value += amount;
    }

    public void SetValue(int amount)
    {
        value = amount;
    }
}