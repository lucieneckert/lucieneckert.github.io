using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Weapon : MonoBehaviour
{
    
    [Header("Descriptive Information")]
    [Tooltip("Name")]
    public string weaponName;
    [Tooltip("Description")]
    public string weaponDesc;
    [Tooltip("HUD Icon")]
    public Sprite weaponIcon;
    
    [Header("Player Stat Effects")]
    [Tooltip("Speed Modifier")]
    public int speed;

    [Header("Weapon Stats")]
    public int MaxAmmo;

    [Header("Actions")]
    [Tooltip("Primary Action")]
    public PrimaryAction Primary;
    [Tooltip("Secondary Action")]
    public SecondaryAction Secondary;
    private WeaponAction[] Actions;


    [Header("Prefab Properties")]
    public Transform ShotOrigin; // usually, camera pos+orientation 

    //public PlayerClientsideController owner;
    public NetworkedPlayer owner;
    public PlayerAccuracy ownerAccuracy;

    private PlayerInventory containingInventory;
    private WeaponHolder containingHolder;
    private Animator animator;

    private int FireHash = Animator.StringToHash("Fire");
    private int EquipHash = Animator.StringToHash("Equip");

    public int Ammo = -1;

    public delegate void ActionFired();
    public static event ActionFired OnActionFired;

    public void InitializeStats() {
        // Reset ammo to defaults
        Ammo = MaxAmmo;
    }

    public void Start() {
        Actions = new WeaponAction[] {Primary, Secondary}; 
        containingInventory = transform.parent.gameObject.GetComponent<PlayerInventory>();
        containingHolder = containingInventory.gameObject.GetComponent<WeaponHolder>();
        ShotOrigin = containingInventory.owner.gameObject.transform.Find("Camera");
        owner = containingInventory.owner;
        ownerAccuracy = owner.gameObject.GetComponent<PlayerAccuracy>();
    }

    public void Awake() {
        animator = GetComponent<Animator>();
    }
    
    private void OnEnable() {
        animator.SetTrigger(EquipHash);
    }

    public void FirePrimary() {
        FireAction(0);
    }

    public void FireSecondary() {
        FireAction(1);
    }

    public void FireAction(int actionIdx) {
        var action = Actions[actionIdx];
        if (action.AmmoCost <= Ammo) {
            action.Fire(gameObject.GetComponent<Weapon>());
            Ammo -= action.AmmoCost;
            AnimateFire();
        } else {
            // action fails
            Debug.Log("No ammo. You absolute doofus. You fool.");
        }
        OnActionFired();
    }

    private void AnimateFire() {
        animator.SetTrigger(FireHash);
    }

    public bool IsADS() {
        return containingHolder.isADS;
    }

    public Vector3 GetShotOrigin(float accuracyModifier) {
        Vector3 initialPosition = ShotOrigin.position;
        float error = ownerAccuracy.CurrentPlayerAccuracy * accuracyModifier / 250;
        float xError = Random.value * error - (error / 2);
        float yError = Random.value * error - (error / 2);
        return new Vector3(initialPosition.x + xError, initialPosition.y + yError, initialPosition.z);
    }
}