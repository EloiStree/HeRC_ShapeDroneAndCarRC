using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
///  Put that script on the wheel prefab of your tank car to in the Resource Folder.
/// </summary>
public class BodyPrefabTag : MonoBehaviour
{
    [Tooltip("Add here a unique id that will only be used by your car.")]
    [SerializeField] string m_carUniqueId;
    public string GetCarUniqueId() { return m_carUniqueId; }
    public void GetCarUniqueId(out string uniqueId) { uniqueId=  m_carUniqueId; }
}
