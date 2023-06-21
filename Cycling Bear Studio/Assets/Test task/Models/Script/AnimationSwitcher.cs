using UnityEngine;

public class AnimationSwitcher : MonoBehaviour
{
    public Animator animator1; // �������� ��� ������� �������
    public Animator animator2; // �������� ��� ������� �������
    public string animationName; // ��� �������� ��� ������������
    public BoxCollider2D boxCollider; // ������ �� BoxCollider2D, ����� �� ����� �������� ������� �������

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            if (boxCollider.bounds.Contains(touchPosition))
            {
                animator1.Play(animationName);
                animator2.Play(animationName);
            }
        }
    }
}
