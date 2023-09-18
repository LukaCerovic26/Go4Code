using System;
using Aplikacija1.DTOs;
using Aplikacija1.Model;
using Aplikacija1.Repository;
using AutoMapper;

namespace Aplikacija1.Service
{
    public class NotificationServiceIMPL : INotificationService
    {
        private readonly INotificationRepository _notificationRepository;
        private readonly IMapper _mapper;

        public NotificationServiceIMPL(INotificationRepository notificationRepository, IMapper mapper)
        {
            _notificationRepository = notificationRepository;
            _mapper = mapper;
        }

        public async Task<Notification> CreateNotification(NotificationCreateRequest request)
        {
            var notificationEntity = _mapper.Map<Notification>(request);
            var result = await _notificationRepository.Create(notificationEntity);

            return _mapper.Map<Notification>(result);
        }

        public async Task<bool> DeleteNotificaiton(NotificationDeleteRequest request)
        {
            var notifications = await _notificationRepository.GetNotificationsForPost(request.PostId);
            var exists = notifications.First(notification => notification.UserId == request.UserId);
            if (exists == null)
            {
                return false;
            }
            await _notificationRepository.Delete(exists);
            return true;
        }

        public async Task<IEnumerable<Notification>> GetAllNotifications()
        {
            return await _notificationRepository.GetAll();
        }

        public async Task<Notification> GetNotificationById(int notificationId)
        {
            return await _notificationRepository.Get(notificationId);
        }

        public async Task<IEnumerable<Notification>> GetNotificationsForPost(int postId)
        {
            return await _notificationRepository.GetNotificationsForPost(postId);
        }

        public async Task<IEnumerable<Notification>> GetNotiificationsByUser(int userId)
        {
            return await _notificationRepository.GetNotificationsByUser(userId);
        }
    }
}
