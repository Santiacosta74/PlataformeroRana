using UnityEngine;

[CreateAssetMenu(fileName = "NewWeaponData", menuName = "Weapon Data", order = 51)]
public class WeaponData : ScriptableObject
{
    public string weaponName;
    public int damage;
    public float range;
}
