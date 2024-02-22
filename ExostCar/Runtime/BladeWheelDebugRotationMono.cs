using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BladeWheelDebugRotationMono : MonoBehaviour
{

    public Vector3 m_rotationAxis = Vector3.right;
    public float m_rotationAnglePerSeconds =360;
    public Transform m_whatToRotate;
    void Update()
    {
        m_whatToRotate.Rotate(m_rotationAxis, m_rotationAnglePerSeconds*Time.deltaTime, Space.Self);
        
    }
    private void Reset()
    {
        m_whatToRotate= transform;
    }
}
