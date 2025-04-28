using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class Move : MonoBehaviour
{
    private float movespeed = 5.0f;
    private void Awake()
    {
        Debug.Log("���� awake��");
    }
    private void Start()
    {
        Debug.Log("���� start��."); 
    }
    private void FixedUpdate()
    {

    }
   
    // Update is called once per frame
    void Update()
    {
        float moveX = 0.0f;
        float moveZ = 0.0f;
        //Keycord�� �̿��� ���.
        
        if (Input.GetKey(KeyCode.W))
        {
            moveZ = 1.0f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveZ = -1.0f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveX = -1.0f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveX = 1.0f;
        }
        
        //�Ű� ���� ���ʴ�� (x,y,z)
        Vector3 moveDirection = new Vector3(moveX, 0.0f, moveZ).normalized;
        
        transform.Translate(moveDirection*movespeed*Time.deltaTime); // �̵��ϴ� �޼���.
/*
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("vertical");

        transform.Translate(Vector3.forward * vertical * movespeed * Time.deltaTime);
        transform.Translate(Vector3.right * horizontal * movespeed * Time.deltaTime);
*/
    }
}
