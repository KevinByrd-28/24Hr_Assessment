using _24_Hour_Assignment.Data;
using _24_Hour_Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Hour_Assignment.Services
{
    public class ReplyService
    {
        private readonly Guid _userId;

        public ReplyService(Guid userId)
        {
            _userId = userId;
        }
        public bool CreateReply(ReplyCreate model)
        {
            var entity =
                new Reply()
                {
                    ReplyComment = model.ReplyComment,
                    CommentID = model.CommentID,
                    UserID = _userId,
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Replies.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<ReplyListItem> GetReplies()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Replies
                        .Where(e => e.UserID == _userId)
                        .Select(
                            e =>
                                new ReplyListItem
                                {
                                    ReplyComment = e.ReplyComment,
                                    CommentID = e.CommentID,
                                    Author = e.Author,
                                    Text = e.Text,
                                }
                        );

                return query.ToArray();
            }
        }

        
        public bool UpdateReply(ReplyEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Replies
                        .Single(e => e.ReplyID == model.ReplyID && e.UserID == _userId);

                entity.ReplyComment = model.ReplyComment;
                entity.CommentID = model.CommentID;
                entity.Author = model.Author;
                entity.Text = model.Text;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteReply(int replyId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Replies
                        .Single(e => e.ReplyID == replyId && e.UserID == _userId);

                ctx.Replies.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
