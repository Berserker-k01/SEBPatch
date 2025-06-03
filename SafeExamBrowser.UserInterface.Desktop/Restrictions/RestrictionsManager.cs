/*
 * Copyright (c) 2025 ETH Zürich, IT Services
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

using System;
using SafeExamBrowser.Logging.Contracts;
using SafeExamBrowser.UserInterface.Contracts.Restrictions;

namespace SafeExamBrowser.UserInterface.Desktop.Restrictions
{
    /// <summary>
    /// Implementation standard du gestionnaire de restrictions
    /// </summary>
    public class RestrictionsManager : IRestrictionsManager
    {
        private readonly ILogger logger;
        private bool restrictionsEnabled = true; // Par défaut, les restrictions sont activées

        /// <summary>
        /// Indique si les restrictions sont actuellement activées
        /// </summary>
        public bool RestrictionsEnabled 
        { 
            get { return restrictionsEnabled; } 
            private set { restrictionsEnabled = value; } 
        }

        /// <summary>
        /// Événement déclenché lorsque l'état des restrictions change
        /// </summary>
        public event EventHandler<bool> RestrictionsToggled;

        public RestrictionsManager(ILogger logger)
        {
            this.logger = logger;
            this.logger.Info("Gestionnaire de restrictions initialisé. État initial: restrictions activées.");
        }

        /// <summary>
        /// Active ou désactive les restrictions
        /// </summary>
        /// <param name="enabled">True pour activer les restrictions, False pour les désactiver</param>
        public void SetRestrictions(bool enabled)
        {
            if (RestrictionsEnabled != enabled)
            {
                RestrictionsEnabled = enabled;
                logger.Info($"Restrictions {(enabled ? "activées" : "désactivées")}");
                OnRestrictionsToggled(enabled);
            }
        }

        /// <summary>
        /// Bascule l'état des restrictions (activées <-> désactivées)
        /// </summary>
        public void ToggleRestrictions()
        {
            SetRestrictions(!RestrictionsEnabled);
        }

        private void OnRestrictionsToggled(bool enabled)
        {
            RestrictionsToggled?.Invoke(this, enabled);
        }
    }
}
