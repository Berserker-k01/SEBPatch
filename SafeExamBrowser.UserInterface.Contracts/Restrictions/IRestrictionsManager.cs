/*
 * Copyright (c) 2025 ETH Zürich, IT Services
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

using System;

namespace SafeExamBrowser.UserInterface.Contracts.Restrictions
{
    /// <summary>
    /// Interface définissant un service de gestion des restrictions pour SEB.
    /// Permet d'activer/désactiver les restrictions et de notifier les changements d'état.
    /// </summary>
    public interface IRestrictionsManager
    {
        /// <summary>
        /// Indique si les restrictions sont actuellement activées
        /// </summary>
        bool RestrictionsEnabled { get; }

        /// <summary>
        /// Événement déclenché lorsque l'état des restrictions change
        /// </summary>
        event EventHandler<bool> RestrictionsToggled;

        /// <summary>
        /// Active ou désactive les restrictions
        /// </summary>
        /// <param name="enabled">True pour activer les restrictions, False pour les désactiver</param>
        void SetRestrictions(bool enabled);

        /// <summary>
        /// Bascule l'état des restrictions (activées <-> désactivées)
        /// </summary>
        void ToggleRestrictions();
    }
}
