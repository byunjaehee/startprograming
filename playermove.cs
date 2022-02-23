using UnityEngine;

// 플레이어 캐릭터를 사용자 입력에 따라 움직이는 스크립트
public class PlayerMovement : MonoBehaviour {
    public float moveSpeed = 5f; // 앞뒤 움직임의 속도
    public float rotateSpeed = 180f; // 좌우 회전 속도


    private PlayerInput playerInput; // 플레이어 입력을 알려주는 컴포넌트
    private Rigidbody playerRigidbody; // 플레이어 캐릭터의 리지드바디
    private Animator playerAnimator; // 플레이어 캐릭터의 애니메이터

    private void Start() 
    {
        playerInput = GetComponent<PlayerInput>();
        playerRigidbody= GetComponent<Rigidbody>();
        playerAnimator= GetComponent<Animator>();
        // 사용할 컴포넌트들의 참조를 가져오기
    }

    // FixedUpdate는 물리 갱신 주기에 맞춰 실행됨
    private void FixedUpdate() 
    {
        Rotate();

        Move();

        playerAnimator.SetFloat("Move", playerInput.move);
        // 물리 갱신 주기마다 움직임, 회전, 애니메이션 처리 실행
    }

    // 입력값에 따라 캐릭터를 앞뒤로 움직임
    private void Move() 
    {
        Vector3 moveDistance = playerInput.move * transform.forward * moveSpeed 
        *Time.deltaTime;
        //상대적으로 앞쪽 방향으로 움직임일 때의 Player의 입력 X 앞쪽 방향 X 속력 X 시간

        playerRigidbody.MovePosition(playerRigidbody.position+moveDistance);
        //상대 위치가 아닌 전역 위치 사용. 현재위치+움직인 위치로 player의 위칫값 변경


    }

    // 입력값에 따라 캐릭터를 좌우로 회전
    private void Rotate() 
    {
        float turn = playerInput.rotate* rotateSpeed * Time.deltaTime;
        //회전은 플레이어가 입력 x 회전 속도 x 시간

        playerRigidbody.rotation= playerRigidbody.rotation* Quaternion.Euler(0, turn,0f);

        //리지드 바디의 회전은 player 리지드바디의 회전x 쿼터니언 회전값(회전에서 더 회전하려면 쿼터니언 사용함)

    }
}