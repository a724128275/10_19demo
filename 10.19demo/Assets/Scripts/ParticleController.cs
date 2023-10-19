using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    public ParticleSystem particleSystem;
    public int iscol;
    GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.Find("bowl");
    }

    // Update is called once per frame
    void Update()
    {
        iscol = obj.GetComponent<Bowl>().iscollidered;
        if (iscol == 1)
        {
            particleSystem.Play();
        }
        else if (iscol == 0)
        {
            particleSystem.Stop();
        }
    }
}
