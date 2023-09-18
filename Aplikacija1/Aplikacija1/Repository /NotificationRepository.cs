using System;
using Aplikacija1.Model;
using Aplikacija1.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Aplikacija1.Repository
{
	public class NotificationRepository : INotificationRepository
	{
        private readonly AppDbContext _context;
        private readonly DbSet<Notification> _collection;

        public NotificationRepository(AppDbContext dbContext)
        {
            _context = dbContext;
            _collection = _context.Notifications;
        }

        public async Task<Notification> Create(Notification notification)
        {
            notification.CreatedAt = DateTime.Now;

            await _collection.AddAsync(notification);
            await _context.SaveChangesAsync();

            return notification;
        }

        public async Task<Notification> Get(int id)
        {
            return await _collection.AsNoTracking().FirstOrDefaultAsync(notification => notification.Id == id);
        }

        public async Task<IEnumerable<Notification>> GetAll()
        {
            return await _collection.AsNoTracking().ToListAsync();
        }

        public async Task Delete(Notification notification)
        {
            _collection.Remove(notification);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Notification>> GetNotificationsForPost(int postId)
        {
            return await _collection.AsNoTracking().Where(notification => notification.PostId == postId).ToListAsync();
        }

        public async Task<IEnumerable<Notification>> GetNotificationsByUser(int userId)
        {
            return await _collection.AsNoTracking().Where(notification => notification.UserId == userId).ToListAsync();
        }
    }
}

