using _24_Hour_Assignment.Data;
using _24_Hour_Assignment.Models;
using _24_Hour_Assignment.Models.Like;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Hour_Assignment.Services
{
    public class LikeService
    {
        private readonly Guid _userId;

        public LikeService(Guid userId)
        {
            _userId = userId;
        }
        public bool CreateLike(LikeCreate model)
        {
            var entity =
                new Like()
                {
                    Liker = model.Liker
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Likes.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<LikeListItem> GetLikes()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Likes
                        .Where(e => e.UserID == _userId)
                        .Select(
                            e =>
                                new LikeListItem
                                {
                                    Liker = e.Liker,
                                    LikedPost = e.LikedPost,
                                }
                        );

                return query.ToArray();
            }
        }

        public bool DeleteLike(int likeId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Likes
                        .Single(e => e.LikeID == likeId && e.LikeID == likeId);

                ctx.Likes.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
