using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
///  Put that script somewhere in the childrend of the body prefab of your tank car in the Resource Folder.
/// </summary>
public class CarRCNameAndIdTag : MonoBehaviour
{
    [Tooltip("Add here a unique id that will only be used by your car.")]
    [SerializeField] string m_carUniqueId;
    [Tooltip("What name should be display for the car ?")]
    [SerializeField] string m_carDisplayName;
    public string GetCarUniqueId() { return m_carUniqueId; }
    public void GetCarUniqueId(out string uniqueId) { uniqueId = m_carUniqueId; }
    public string GetCarDisplayName() { return m_carDisplayName; }
}
