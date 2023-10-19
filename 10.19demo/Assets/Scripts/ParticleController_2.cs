using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ParticleController_2 : MonoBehaviour
{
    public Slider slider;
    public ParticleSystem particleSystem;
    public GameObject blender;
    public GameObject sliderobj;
    // Start is called before the first frame update
    void Start()
    {
        particleSystem.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value == 1)
        {
            particleSystem.Play();
            sliderobj.SetActive(false);
            blender.SetActive(false);
        }
    }
}
