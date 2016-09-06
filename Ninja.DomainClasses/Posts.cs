using System.Collections.Generic;
using System;
using NinjaDomain.Classes.Interfaces;

namespace NinjaDomain.Classes
{
    public class Post : IModificationHistory
    {
        public Post()
        {
        
        }
        public int PostID { get; set; }
        public string PostText { get; set; }
        
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsDirty { get; set; }
    }
}