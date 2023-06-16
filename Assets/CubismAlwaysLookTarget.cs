using Live2D.Cubism.Framework.LookAt;
using UnityEngine;

public class CubismAlwaysLookTarget : MonoBehaviour, ICubismLookTarget
{
    Vector3 ICubismLookTarget.GetPosition()
    {
        var targetPosition = Input.mousePosition;

        targetPosition = Camera.main.ScreenToWorldPoint(targetPosition);
        //Debug.Log(targetPosition);
        return targetPosition;
        //return Vector3.zero;
    }


    public bool IsActive()
    {
        return true;
    }
}