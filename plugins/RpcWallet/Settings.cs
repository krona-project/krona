﻿using Microsoft.Extensions.Configuration;

namespace Krona.Plugins
{
    internal class Settings
    {
        public Fixed8 MaxFee { get; }

        public static Settings Default { get; private set; }

        private Settings(IConfigurationSection section)
        {
            this.MaxFee = Fixed8.Parse(section.GetValue("MaxFee", "0.1"));
        }

        public static void Load(IConfigurationSection section)
        {
            Default = new Settings(section);
        }
    }
}
