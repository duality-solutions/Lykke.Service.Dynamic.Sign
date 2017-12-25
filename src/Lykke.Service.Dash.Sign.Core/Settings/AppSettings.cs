﻿using Lykke.Service.Dash.Sign.Core.Settings.ServiceSettings;
using Lykke.Service.Dash.Sign.Core.Settings.SlackNotifications;

namespace Lykke.Service.Dash.Sign.Core.Settings
{
    public class AppSettings
    {
        public DashSignSettings SignService { get; set; }
        public SlackNotificationsSettings SlackNotifications { get; set; }
    }
}
