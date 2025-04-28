using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class Move : MonoBehaviour
{
    private float movespeed = 5.0f;
    private void Awake()
    {
        Debug.Log("나는 awake야");
    }
    private void Start()
    {
        Debug.Log("나는 start야."); 
    }
    private void FixedUpdate()
    {

    }
   
    // Update is called once per frame
    void Update()
    {
        float moveX = 0.0f;
        float moveZ = 0.0f;
        //Keycord를 이용한 방법.
        
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
        
        //매개 변수 차례대로 (x,y,z)
        Vector3 moveDirection = new Vector3(moveX, 0.0f, moveZ).normalized;
        
        transform.Translate(moveDirection*movespeed*Time.deltaTime); // 이동하는 메서드.
/*
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("vertical");

        transform.Translate(Vector3.forward * vertical * movespeed * Time.deltaTime);
        transform.Translate(Vector3.right * horizontal * movespeed * Time.deltaTime);
*/
    }
}
