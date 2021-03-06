﻿using System;

namespace ThinkUp.Sdk.Services
{
    public interface INotificationService
    {
        event EventHandler<NotificationEventArgs> Notification;

        void SendBroadcast(int notificationType, object serverMessage, params string[] userNames);

        void Send(int notificationType, object serverMessage, string userName);
    }
}
