using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugCarDimensionWheelRotationMono : MonoBehaviour
{
    public bool m_isActive=true;
    public bool m_isInverse;
    public float m_rotationSpeed=180;
    public Vector3 m_axisOfRotation= new Vector3(0,1,0);
    public Transform m_whatToRotate;



    void Update()
    {
        if (!m_isActive)
            return;

        m_whatToRotate.Rotate(m_axisOfRotation
            , Time.deltaTime *
            m_rotationSpeed *
            (m_isInverse ? -1f : 1f)
            , Space.Self);

    }

    private void Reset()
    {
        m_whatToRotate = transform;
    }
}
