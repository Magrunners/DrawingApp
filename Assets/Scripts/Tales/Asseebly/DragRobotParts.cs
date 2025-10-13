using UnityEngine;
using UnityEngine.EventSystems;

public class DragRobotParts : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private Camera mainCamera;
    private Vector3 dragOffset;
    private bool isDragging = false;



    void Start()
    {
        mainCamera = Camera.main;
        if (mainCamera.GetComponent<PhysicsRaycaster>() == null)
            mainCamera.gameObject.AddComponent<PhysicsRaycaster>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        isDragging = true;

        // Вычисляем смещение от центра объекта до точки клика
        Vector3 screenPos = mainCamera.WorldToScreenPoint(transform.position);
        dragOffset = transform.position - mainCamera.ScreenToWorldPoint(
            new Vector3(eventData.position.x, eventData.position.y, screenPos.z));
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (!isDragging) return;

        // Позиционируем объект с учетом смещения
        Vector3 screenPos = new Vector3(eventData.position.x, eventData.position.y,
            mainCamera.WorldToScreenPoint(transform.position).z);

        transform.position = mainCamera.ScreenToWorldPoint(screenPos) + dragOffset;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        isDragging = false;
    }
}