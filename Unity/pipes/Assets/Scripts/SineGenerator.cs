using System.Collections;
using System.Collections.Generic;
using System;

public class SineDataGenerator : IEnumerator<float>
{
    private float _state = 0;

    public float Current
    {
        get
        {
            return (float)Math.Abs(Math.Sin(_state));
        }
    }

    object IEnumerator.Current
    {
        get
        {
            return Current;
        }
    }

    public void Dispose()
    {

    }

    public bool MoveNext()
    {
        _state += 0.1f;
        return true;
    }

    public void Reset()
    {
        _state = 0;
    }
}