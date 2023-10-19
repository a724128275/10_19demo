using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Battermeshchange : MonoBehaviour
{
    public Slider slider;
    public Material mat1;
    public Material mat2;
    public Material mat3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (slider.value >= 0.3f && slider.value < 0.6f)
        {
          var mesh = GetComponent<MeshRenderer>();
            mesh.sharedMaterial = mat2;
        }
        if (slider.value >= 0.6f && slider.value < 0.9f)
        {
            var mesh = GetComponent<MeshRenderer>();
            mesh.sharedMaterial = mat3;
        }
    }
}
