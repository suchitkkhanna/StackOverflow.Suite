using System;

namespace StackOverflow.Domain
{
    public class DocTagVersion
    {

        public DocTagVersion(string id, string docTagId, string name, string groupName, DateTime createDateTime, DateTime releaseDate, DateTime lastEditDate, string lastEditUserId)
        {
            Id = id;
            DocTagId = docTagId;
            Name = name;
            GroupName = groupName;
            CreateDateTime = createDateTime;
            ReleaseDate = releaseDate;
            LastEditDate = lastEditDate;
            LastEditUserId = lastEditUserId;
        }

        public string Id { get; }

        public string DocTagId { get; }

        public string Name { get; }

        public string GroupName { get; }

        public DateTime CreateDateTime { get; }

        public DateTime ReleaseDate { get; }

        public DateTime LastEditDate { get; }

        public string LastEditUserId { get; }

    }
}