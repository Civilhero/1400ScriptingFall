using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IDMatch : MonoBehaviour
{
    public ID id;
    public UnityEvent match, noMatch;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var otherID = collision.GetComponent<IDbehave>();
        if (otherID.id == id)
        {
            match.Invoke(); 
            Destroy(otherID.gameObject);
        }
        else
        {
            noMatch.Invoke();
            Destroy(otherID.gameObject);
        }
    }
}