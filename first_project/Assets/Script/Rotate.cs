using UnityEngine;

public class Rotate : MonoBehaviour
{

    //public Transform target;
    // Update is called once per frame
    void Update()
    {
        // Ű �Է��� �޾Ƽ� ȸ���ϴ� ���� ������.(Y��)+ �̵��ϴ� �ͱ���.
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
