using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Bowl : MonoBehaviour
{
    public GameObject obj;
    public float speed;//旋转速度
    public int iscollidered = 0;
    public Slider slider;
    //blender和bowl碰撞时且鼠标在指定范围拖拽物体移动，增加slider.value
    //根据slidervalue值改变播放动画
    // Start is called before the first frame update
    void Start()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        iscollidered = 1;
        slider.value += 0.1f;
    }
    private void OnTriggerExit(Collider other)
    {
        iscollidered = 0;
    }
    // Update is called once per frame
    void Update()
    {
        if (iscollidered == 1)
        {
            obj.transform.Rotate(0f, speed * Time.deltaTime, 0f, Space.Self);
        }
    }
}
