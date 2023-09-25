using System;
using Aplikacija1.DTOs;
using Aplikacija1.Model;

namespace Aplikacija1.Service
{
	public interface INotificationService
	{
        public Task<Notification> GetNotificationById(int notificationId);
        public Task<IEnumerable<Notification>> GetAllNotifications();
        public Task<IEnumerable<Notification>> GetNotificationsForPost(int postId);
        public Task<IEnumerable<Notification>> GetNotiificationsByUser(String userId);
        public Task<Notification> CreateNotification(NotificationCreateRequest request);
        public Task<bool> DeleteNotificaiton(NotificationDeleteRequest request);
    }
}

