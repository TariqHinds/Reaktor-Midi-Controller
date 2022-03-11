using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystemEmitOnEvent1 : MonoBehaviour
{
    ParticleSystem ps;
    public GameObject particlePrefab; 
    // Start is called before the first frame update
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
        PianoKey.OnPianoKeyDown += Emit;
    }

    // Update is called once per frame
    void Emit(int Note)
    {
        var go = Instantiate(particlePrefab, transform.position, transform.rotation);
       ps = go.GetComponent<ParticleSystem>();
       ps.startColor = new Color (Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        ps.Emit(Note); 
        Destroy(go, 5f); 
    }
}
