using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BlenderMove : MonoBehaviour
{
    public Image image;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        void Trans_Mv()
        {
            if (Input.GetMouseButton(0))
            {
                //显示旋转箭头
                image.enabled = true;
                Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);
                Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPos.z);
                transform.position = Camera.main.ScreenToWorldPoint(mousePos);
            }
            else
            {
                image.enabled = false;
            }
        }
        Trans_Mv();//移动
    }
}
