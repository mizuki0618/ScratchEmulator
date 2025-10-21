using NaughtyAttributes;
using UnityEngine;

public class RandomScreenMover : MonoBehaviour
{
    [SerializeField, Label("�����_���ɕ\��")] private float _distanceFromCamera = 10f;

    [Button("���s")]

    public void MoveToRandomScreenPosition()
    {
        Camera mainCam = Camera.main;
        if (mainCam == null)
        {
            return;
        }
        float randomX = Random.Range(0f, Screen.width);
        float randomY = Random.Range(0f, Screen.height);

        Vector3 screenPosition = new Vector3(randomX, randomY, _distanceFromCamera);
        Vector3 worldPosition = mainCam.ScreenToWorldPoint(screenPosition);

        transform.position = worldPosition;
    }
}