using UnityEngine;
using DG.Tweening;

public class RandomRotationOnSpotLights : MonoBehaviour
{
    [SerializeField] private float speed = 1;
    [SerializeField] private RotateMode rotateMode = default;
    [SerializeField] private Vector2 xRange = Vector2.zero;
    [SerializeField] private Vector2 zRange = default(Vector2);
    [SerializeField] private Vector2 yRange = default;

    private void Start()
    {
        LookToRandomRotation();
    }

    private void LookToRandomRotation()
    {
        var newX = Random.Range(xRange.x, xRange.y);
        var newZ = Random.Range(zRange.x, zRange.y);
        var newY = Random.Range(yRange.x, yRange.y);

        transform.DOLocalRotate(new Vector3(newX, newY, newZ), speed, rotateMode).SetSpeedBased(true).OnComplete(LookToRandomRotation);
    }
}
