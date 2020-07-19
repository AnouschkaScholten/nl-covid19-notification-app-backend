// Copyright 2020 De Staat der Nederlanden, Ministerie van Volksgezondheid, Welzijn en Sport.
// Licensed under the EUROPEAN UNION PUBLIC LICENCE v. 1.2
// SPDX-License-Identifier: EUPL-1.2

using Microsoft.Extensions.Configuration;
using NL.Rijksoverheid.ExposureNotification.BackEnd.Components.Configuration;

namespace NL.Rijksoverheid.ExposureNotification.BackEnd.Components.ProtocolSettings
{
    public class StandardGaenContentConfig : AppSettingsReader, IGaenContentConfig
    {
        public StandardGaenContentConfig(IConfiguration config, string prefix = "Gaen:ExposureKeySet") : base(config, prefix) { }
        public int ExposureKeySetCapacity => GetConfigValue("Capacity", 21);
        public int ExposureKeySetLifetimeDays => GetConfigValue("LifetimeDays", 14);
    }
}