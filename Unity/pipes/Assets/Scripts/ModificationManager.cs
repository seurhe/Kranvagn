using UnityEngine;
using System.Collections;
using HoloToolkit.Unity;
using System;
using System.Collections.Generic;

public class ModificationManager : MonoBehaviour {

    public static ModificationManager Instance;

    private List<Modifiable> modifiables = new List<Modifiable>();

    private GestureManager _gestureManager;


    // Use this for initialization
    void Start()
    {
        Instance = this;

        _gestureManager = GestureManager.Instance;
        _gestureManager.ManipulationStarted += ManipulationStarted;
        _gestureManager.ManipulationCompleted += MainpulationCompleted;
    }

    private void MainpulationCompleted()
    {
        modifiables.ForEach(m => m.ModificationStarted());
    }

    private void ManipulationStarted()
    {
        modifiables.ForEach(d => d.ModificationStarted());
    }

    public void Register(Modifiable modifiable)
    {
        modifiables.Add(modifiable);
    }

    public void Deregister(Modifiable modifiable)
    {
        modifiables.Remove(modifiable);
    }

    public void DerigesterAll()
    {
        foreach (var mod in modifiables.ToArray())
        {
            mod.Disable();
        }
        modifiables.Clear();
    }
}
