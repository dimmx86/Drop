using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private HashSet<TriggerZone> _checkingZones;

    public HashSet<TriggerZone> CheckingZones => _checkingZones;


    private void OnEnable()
    {
        Init();
    }

    private void Init()
    {
        _checkingZones = new HashSet<TriggerZone>();
    }

    public void SetCheckingZones(HashSet<TriggerZone> checkingZones)
    {
        _checkingZones = checkingZones;
    }

    public bool ThisZoneChecking(TriggerZone zone)
    {
        return _checkingZones.Contains(zone);
    }

    public void AddCheckingZones(TriggerZone zone)
    {
        _checkingZones.Add(zone);
    }


}
