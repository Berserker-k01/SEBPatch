/*
 * Copyright (c) 2025 ETH Zürich, IT Services
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

using System;

namespace SafeExamBrowser.Monitoring.Contracts.Display
{
    /// <summary>
    /// Interface simplifiée pour gérer le basculement des restrictions d'affichage
    /// </summary>
    public interface IToggleRestrictionsHandler
    {
        /// <summary>
        /// Événement déclenché lorsque l'état des restrictions change
        /// </summary>
        event EventHandler<bool> RestrictionsToggled;

        /// <summary>
        /// Enregistre un moniteur d'affichage pour recevoir les notifications de basculement de restrictions
        /// </summary>
        /// <param name="display">Le moniteur d'affichage à enregistrer</param>
        void RegisterDisplayMonitor(IDisplayMonitor display);
    }
}
