using UnityEngine;

public class Rotate : MonoBehaviour
{

    //public Transform target;
    // Update is called once per frame
    void Update()
    {
        // 키 입력을 받아서 회전하는 것을 만들어라.(Y축)+ 이동하는 것까지.
        float moveY = 0.0f;
        if (Input.GetKey(KeyCode.Q))
        {
            moveY = 1.0f;
        }
        if (Input.GetKey(KeyCode.E))
        {
            moveY = -1.0f;
        }

       
transform.Rotate(Vector3.up*moveY,100f*Time.deltaTime,Space.World);
    }
}
