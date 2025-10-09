using UnityEngine;
using UnityEngine.EventSystems;

public class DragRobotParts : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Camera camera3D;
    private Vector3 dragOffset;
    private bool isDragging = false;

    void Start()
    {
        if (camera3D.GetComponent<PhysicsRaycaster>() == null)
            camera3D.gameObject.AddComponent<PhysicsRaycaster>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        isDragging = true;

        // Вычисляем смещение от центра объекта до точки клика
        Vector3 screenPos = camera3D.WorldToScreenPoint(transform.position);
        dragOffset = transform.position - camera3D.ScreenToWorldPoint(
            new Vector3(eventData.position.x, eventData.position.y, screenPos.z));
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (!isDragging) return;

        // Позиционируем объект с учетом смещения
        Vector3 screenPos = new Vector3(eventData.position.x, eventData.position.y,
            camera3D.WorldToScreenPoint(transform.position).z);

        transform.position = camera3D.ScreenToWorldPoint(screenPos) + dragOffset;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        isDragging = false;
    }
}