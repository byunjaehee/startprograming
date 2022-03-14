using UnityEngine;

// 왼쪽 끝으로 이동한 배경을 오른쪽 끝으로 재배치하는 스크립트
public class BackgroundLoop : MonoBehaviour {
    private float width; // 배경의 가로 길이

    private void Awake() {

        BoxCollider2D backgroundCollider = GetComponent<BoxCollider2D>();
        width= backgroundCollider.size.x;
        // 가로 길이를 측정하는 처리
    }

    private void Update() {

        if(transform.position.x <= -width)
        {
            Reposition();
        }

    }

  //reposition
    private void Reposition() {

        Vector2 offset= new Vector2(width*2f,0);
        transform.position=(Vector2)transform.position+offset;
        
    }
}