using System;

namespace StackOverflow.DumpReaderApi.Repository
{
    public class DocTag
    {

        public DocTag(string id, string tag, string title, DateTime creationDateTime, string helloWorldDocTopicId, int topicCount)
        {
            Id = id;
            Tag = tag;
            Title = title;
            CreateDateTime = creationDateTime;
            HelloWorldDocTopicId = helloWorldDocTopicId;
            TopicCount = topicCount;
        }

        public string Id { get; }

        public string Tag { get; }

        public string Title { get; }

        public DateTime CreateDateTime { get; }

        public string HelloWorldDocTopicId { get; }

        public int TopicCount { get; }

      
    }
}