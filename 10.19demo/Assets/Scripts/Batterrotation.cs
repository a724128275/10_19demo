using System.Collections;
using UnityEngine;

public class Batterrotation : MonoBehaviour
{

    public int iscol;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        int iscol = GameObject.Find("bowl").GetComponent<Bowl>().iscollidered;
    }

    // Update is called once per frame
    void Update()
    {
        if (iscol == 1)
        {
            transform.Rotate(0f, speed * Time.deltaTime, 0f, Space.Self);
        }
    }
}
