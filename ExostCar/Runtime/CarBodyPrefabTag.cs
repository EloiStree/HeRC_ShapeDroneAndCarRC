using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
///  Put that script on the wheel prefab of your tank car to in the Resource Folder.
/// </summary>
public class CarBodyPrefabTag : MonoBehaviour
{
    [Tooltip("Add here a unique id that will only be used by your car.")]
    [SerializeField] string m_uniqueId;
    public string GetUniqueId() { return m_uniqueId; }
    public void GetUniqueId(out string uniqueId) { uniqueId=  m_uniqueId; }
}
