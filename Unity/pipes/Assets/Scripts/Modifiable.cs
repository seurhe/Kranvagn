using System;
using UnityEngine;
using System.Collections;
using HoloToolkit.Unity;
using UnityEngine.Events;

public abstract class Modifiable : MonoBehaviour
{
    public bool ModificationEnabled = false;

    public bool LockX = false;
    public bool LockY = false;
    public bool LockZ = false;

    protected GestureManager _gestureManager;
    protected Vector3 _dragStartPosition;
    private Vector3 _startPosition;
    private Vector3 _initialPosition;
    private Vector3 _initialSize;
    private Vector3 _initialAngles;
    private bool _dragStarted;

    private void Start()
    {
        _initialSize = transform.localScale;
        _initialPosition = transform.localPosition;
        _initialAngles = transform.localEulerAngles;
        _gestureManager = GestureManager.Instance;
    }

    public void Enable()
    {
        if (!gameObject.activeSelf)
            return;

        ModificationEnabled = true;
        ModificationManager.Instance.Register(this);
    }

    public void Disable()
    {
        if (!gameObject.activeSelf)
            return;

        ModificationEnabled = false;
        ModificationManager.Instance.Deregister(this);
    }

    public void Update()
    {
        if (!_dragStarted || !ModificationEnabled || !_gestureManager.ManipulationInProgress)
            return;

        PerformModification();
    }

    public virtual void ModificationStarted()
    {
        if (!ModificationEnabled)
            return;

        _dragStartPosition = transform.localPosition;
        _dragStarted = true;
    }

    public void ModificationFinished()
    {
        if (!ModificationEnabled || !_dragStarted)
            return;

        PerformModification();
        BroadcastMessage("SetPositions");
        _dragStarted = false;
    }

    public abstract void PerformModification();

    public void Reset()
    {
        transform.position = _initialPosition;
        transform.localScale = _initialSize;
        transform.localEulerAngles = _initialAngles;

        BroadcastMessage("SetPositions");
    }
}
