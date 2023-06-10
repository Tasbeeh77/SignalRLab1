using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using SignalRLab1.Models;

namespace SignalRLab1.Hubs
{
    public class CommentHub : Hub
    {
        private readonly productDB _context;
        public CommentHub(productDB context)
        {
            _context = context;
        }
        public void NewCommentFromClientToServer(string name, string message)
        {
            Clients.All.SendAsync("NotifyCommentFromServerToClient", name, message);
        }
        public async Task AddComment(int productId, string userName, string text)
        {
            var newcomment = new Comment
            {
                ProductId = productId,
                UserName = userName,
                Text = text
            };
            _context.Comments.Add(newcomment);
            await _context.SaveChangesAsync();
            var comments = await _context.Comments
                .Where(c => c.ProductId == productId)
                .ToListAsync();
            await Clients.All.SendAsync("NewCommentAdded", productId, userName, text, comments);
        }
    }
}
