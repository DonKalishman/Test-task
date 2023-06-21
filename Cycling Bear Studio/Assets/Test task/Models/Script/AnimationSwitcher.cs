using UnityEngine;

public class AnimationSwitcher : MonoBehaviour
{
    public Animator animator1; // Аниматор для первого объекта
    public Animator animator2; // Аниматор для второго объекта
    public string animationName; // Имя анимации для проигрывания
    public BoxCollider2D boxCollider; // Ссылка на BoxCollider2D, чтобы мы могли получить границы объекта

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
