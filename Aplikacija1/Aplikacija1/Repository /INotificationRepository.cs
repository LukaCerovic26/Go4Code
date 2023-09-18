using System;
using Aplikacija1.Model;

namespace Aplikacija1.Repository
{
	public interface INotificationRepository
	{
		public Task<Notification> Create(Notification notification);
		public Task<Notification> Get(int id);
		public Task<IEnumerable<Notification>> GetAll();
		public Task Delete(Notification notification);
        public Task<IEnumerable<Notification>> GetNotificationsForPost(int postId);
        public Task<IEnumerable<Notification>> GetNotificationsByUser(int userId);

    }
}

