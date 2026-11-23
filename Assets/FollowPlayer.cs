using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    void LateUpdate()
    {
        Vector3 offset = new Vector3(0, 4, -7);

        transform.position = player.transform.TransformPoint(offset);

        Vector3 lookPoint = player.transform.position + player.transform.forward * 10f;
        lookPoint.y += 1f;

        transform.LookAt(lookPoint);
    }
}