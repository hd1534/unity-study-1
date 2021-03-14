using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // 키보드
        if (Input.anyKeyDown)
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");


        if (Input.anyKey)
            Debug.Log("플레이어가 아무 키를 누르고 있습니다.");


        if (Input.GetKeyDown(KeyCode.Return))   // Return == 엔터키
            Debug.Log("아이템을 구입하였습니다.");

        if (Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("왼쪽으로 이동 중");

        if (Input.GetKeyUp(KeyCode.LeftArrow))
            Debug.Log("왼쪽으로 이동을 멈추었습니다.");

        
        // 마우스
        if (Input.GetMouseButtonDown(0))
            Debug.Log("미사일 발사!");

        if (Input.GetMouseButton(0))
            Debug.Log("미사일 모으는 중...");

        if (Input.GetMouseButtonUp(0))
            Debug.Log("슈퍼 미사일 발사!!");

        // 버튼
        if (Input.GetButtonDown("Jump"))
            Debug.Log("점프!");

        if (Input.GetButton("Jump"))
            Debug.Log("점프 모으는 중...");

        if (Input.GetButtonUp("Jump"))
            Debug.Log("슈퍼 점프!!");

        if (Input.GetButton("Horizontal")) 
            if (Input.GetAxisRaw("Horizontal") < 0)
                Debug.Log("왼쪽으로 이동 중..." + Input.GetAxis("Horizontal"));
            else
                Debug.Log("오른쪽으로 이동 중..." + Input.GetAxis("Horizontal"));
    }
}
