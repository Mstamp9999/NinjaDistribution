using System.Collections.Generic;
using System;
using NinjaDomain.Classes.Interfaces;

namespace NinjaDomain.Classes
{
  public class Topic : IModificationHistory
  {
    public Topic() {
     Topics = new List<Topic>();
    }
    public int TopicId { get; set; }
    public string TopicSubject { get; set; }
    public List<Topic> Topics { get; set; }

    public DateTime DateCreated { get; set; }
    public DateTime DateModified { get; set; }
    public bool IsDirty { get; set; }
  }
}