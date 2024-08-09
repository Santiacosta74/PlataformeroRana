using UnityEngine;

public class Weapon : MonoBehaviour
{
    public WeaponData weaponData;

    void Start()
    {
        Debug.Log($"Weapon: {weaponData.weaponName}, Damage: {weaponData.damage}, Range: {weaponData.range}");
    }
}
