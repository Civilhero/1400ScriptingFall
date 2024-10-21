using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(requiredComponent: typeof(ParticleSystem), requiredComponent2:typeof(Collider2D))]
public class EffectBehave : MonoBehaviour
{
    private ParticleSystem Effects;
    public int firstPartNum = 10;
    public int secondPartNum = 20;
    public int thirdPartNum = 30;
    public float PartDelay = 0.5f;

    private void Start()
    {
        Effects = GetComponent<ParticleSystem>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<MoveChar>())
        {
           StartCoroutine(routine:EmitParticlesCoroutine());
        }
    }
    
    private IEnumerator EmitParticlesCoroutine()
    {
        Effects.Emit(firstPartNum);
        yield return new WaitForSeconds(PartDelay);
            
        Effects.Emit(secondPartNum);
        yield return new WaitForSeconds(PartDelay);
            
        Effects.Emit(thirdPartNum);    
    }
}
