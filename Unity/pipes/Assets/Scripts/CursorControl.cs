// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using HoloToolkit.Unity;
using UnityEngine;

/// <summary>
/// CursorManager class takes Cursor GameObjects.
/// One that is on Holograms and another off Holograms.
/// 1. Shows the appropriate Cursor when a Hologram is hit.
/// 2. Places the appropriate Cursor at the hit position.
/// 3. Matches the Cursor normal to the hit surface.
/// </summary>
public partial class CursorControl : Singleton<CursorControl>
{
    void LateUpdate()
    {
        if (GazeManager.Instance == null)
        {
            return;
        }

        // Place the cursor at the calculated position.
        this.gameObject.transform.position = GazeManager.Instance.Position;
    }
}